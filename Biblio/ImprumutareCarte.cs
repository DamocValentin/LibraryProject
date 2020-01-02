using System;
using System.Collections.Generic;
using System.Linq;
using Biblio.Context;

namespace Biblio
{
    public class ImprumutareCarte
    {
        public List<Gen> getAllGens()
        {
            DatabaseContext context = new DatabaseContext();
            List<Gen> listaGenuri = new List<Gen>();
            listaGenuri = context.Gens.ToList();
            return listaGenuri;
        }

        public string getTitluCarteById(int idCarte)
        {
            DatabaseContext context = new DatabaseContext();
            return context.Cartes.FirstOrDefault(x => x.CarteId.Equals(idCarte)).Titlu;
        }

        public Cititor GetCititorById(int idCititor)
        {
            DatabaseContext context = new DatabaseContext();
            return context.Cititors.FirstOrDefault(x => x.CititorId.Equals(idCititor));
        }

        public int getGenIdByCarteId(int carteId)
        {
            DatabaseContext context = new DatabaseContext();
            return context.Cartes.FirstOrDefault(x => x.CarteId.Equals(carteId)).GenId;
        }

        public short getStareCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            DatabaseContext context = new DatabaseContext();
            short stare = context.Cititors.FirstOrDefault(x => x.Nume.Equals(numeCititor) && x.Prenume.Equals(prenumeCititor)
                && x.Adresa.Equals(adresaCititor) && x.Email.Equals(emailCititior)).Stare;
            return stare;
        }

        public string getGenCarteDescriere(int genId)
        {
            DatabaseContext context = new DatabaseContext();
            string descriere = context.Gens.FirstOrDefault(x => x.GenId == genId).Descriere;
            return descriere;
        }

        // returneaza id-ul cititorului daca exista, altfel creeaza un nou cititor si apoi ii returneaza id-ul
        public bool existaCititor(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            bool exista = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                var cititori = context.Cititors;
                foreach (var c in cititori)
                {
                    if (c.Nume.Equals(numeCititor) && c.Prenume.Equals(prenumeCititor) && c.Adresa.Equals(adresaCititor) && c.Email.Equals(emailCititior))
                    {
                        exista = true;
                        break;
                    }
                }
            }
            return exista;
        } 

        public int getCititorId(string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            var cititorId = 0;
            bool exista = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                var cititori = context.Cititors;
                foreach (var c in cititori)
                {
                    if (c.Nume.Equals(numeCititor) && c.Prenume.Equals(prenumeCititor) && c.Adresa.Equals(adresaCititor) && c.Email.Equals(emailCititior))
                    {
                        cititorId = c.CititorId;
                        exista = true;
                        break;
                    }
                }
                if (!exista)
                {
                    Cititor c = new Cititor()
                    {
                        Nume = numeCititor,
                        Prenume = prenumeCititor,
                        Adresa = adresaCititor,
                        Email = emailCititior,
                        Stare = 0
                    };
                    context.Cititors.Add(c);
                    context.SaveChanges();

                    var cititor = context.Cititors.FirstOrDefault(x => x.Nume.Equals(numeCititor) && x.Prenume.Equals(prenumeCititor) && x.Adresa.Equals(adresaCititor) && x.Email.Equals(emailCititior));
                    cititorId = cititor.CititorId;
                }

            }
            return cititorId;
        }

        public List<Carte> getCartiDupaGen(int idGen)
        {
            DatabaseContext context = new DatabaseContext();
            var allbooks = context.Cartes.Include("Autor").Where(x => x.GenId == idGen).ToList();

            var unique_books = new List<Carte>();

            foreach (var book in allbooks)
            {
                if (0 != unique_books.Count(x => x.Titlu.Equals(book.Titlu)
                    && x.Autor.Nume.Equals(book.Autor.Nume)
                    && x.Autor.Prenume.Equals(book.Autor.Prenume))) continue;

                unique_books.Add(book);
            }

            return unique_books;
        }

        public Int16 getStare(int cititorId)
        {
            DatabaseContext context = new DatabaseContext();
            var cititor = context.Cititors.FirstOrDefault(x => x.CititorId == cititorId);
            if(cititor.Stare == 0)
            {
                if(context.Imprumuts.Where(x => x.CititorId == cititorId && (x.DataRestituire > x.DataScadenta)).Count() > 1)
                {
                    context.Cititors.FirstOrDefault(x => x.CititorId == cititorId).Stare = 1;
                    context.SaveChanges();
                    return 1;
                }
            }
            return cititor.Stare;
        }

        //returneaza -1 daca, cartea dorita nu exista, 0 daca este disponibila si a fost adaugat imprumutul,  sau un numar intreg ce reprezinta numarul de zile pana cand va fi disponibila
        public int realizareImprumut(string genCarte, string titluCarte, string numeCititor, string prenumeCititor, string adresaCititor, string emailCititior)
        {
            using(DatabaseContext context = new DatabaseContext())
            {
                var cititorId = getCititorId(numeCititor, prenumeCititor, adresaCititor, emailCititior);
                var carti = context.Cartes.Where(x => x.Titlu.Equals(titluCarte));
                if (carti.Count() == 0)
                    return -1;
                bool libera = false;
                DateTime dataDisponiblia = DateTime.MaxValue;
                int idCarteLibera = 0;
                foreach(var carte in carti)
                {
                    var imprumuturi = context.Imprumuts.Where(i => i.CarteId == carte.CarteId);
                    if(imprumuturi.Count() == 0)
                    {
                        libera = true;
                        idCarteLibera = carte.CarteId;
                        break;
                    }
                    foreach(var imprumut in imprumuturi)
                    {
                        if(imprumut.DataRestituire != null)
                        {
                            libera = true;
                            idCarteLibera = carte.CarteId;
                            break;
                        }
                    }
                    if(libera)
                        break;
                }
                if(libera)
                {
                    Imprumut imprumut = new Imprumut()
                    {
                        CarteId = idCarteLibera,
                        CititorId = cititorId,
                        DataImprumut = DateTime.Now,
                        DataScadenta = DateTime.Now.AddDays(10)
                    };
                    context.Imprumuts.Add(imprumut);
                    context.SaveChanges();
                    return 0;
                }
                return dataDisponiblia.Subtract(DateTime.Now).Days;
            }
        }
    }
}
