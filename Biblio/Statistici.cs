using Biblio.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblio
{
    public class Statistici
    {
        public List<Cititor> getCititoriPerioada(DateTime startDate, DateTime endDate)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var imprumuturi = context.Imprumuts.Where(x => x.DataImprumut < endDate && x.DataImprumut > startDate).ToList();
                var listaCititori = new List<Cititor>();

                foreach (var imprumut in imprumuturi)
                {
                    if (0 != listaCititori.Count(x => x.CititorId == imprumut.CititorId))
                        continue;

                    listaCititori.Add(context.Cititors.FirstOrDefault(x => x.CititorId == imprumut.CititorId));
                }
                return listaCititori;
            }
        }

        public Carte getCarteByName(string numeCarte)
        {
            DatabaseContext context = new DatabaseContext();
            Carte carte = context.Cartes.FirstOrDefault(y => y.Titlu.Equals(numeCarte));
            return carte;
        }

        public List<Carte> getCartiSolicitate()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var listaCarti = new List<Carte>();
                var listaCartiReturnate = new List<Carte>();
                listaCarti = context.Cartes.ToList();
                var listaContoare = new List<int>();
                foreach (var carte in listaCarti)
                {
                    var x = context.Imprumuts.Where(y => y.CarteId == carte.CarteId).Count();
                    listaContoare.Add(x);
                }
                listaContoare.OrderByDescending(p => p).ToList();

                for (int i = 0; i < listaContoare.Count() / 2; i++)
                {
                    foreach (var carte in listaCarti)
                    {
                        if(context.Imprumuts.Where(x => x.CarteId == carte.CarteId).Count() == listaContoare[i])
                        {
                            if (listaCartiReturnate.Count(x => x.Titlu.Equals(carte.Titlu)) > 0)
                                continue;

                            listaCartiReturnate.Add(context.Cartes.FirstOrDefault(x => x.CarteId == carte.CarteId));
                        }
                        
                    }
                }
                return listaCartiReturnate;
            }
        }

        public List<Autor> getAutoriCautati()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var listaAutori = new List<Autor>();
                var listaCartiSolicitate = new List<Carte>();
                listaCartiSolicitate = getCartiSolicitate();
                foreach (var carte in listaCartiSolicitate)
                {
                    if (0 != listaAutori.Count(x => x.AutorId == carte.AutorId))
                        continue;

                    listaAutori.Add(context.Autors.FirstOrDefault(x => x.AutorId == carte.AutorId));
                }
                return listaAutori;
            }
        }

        public List<Gen> getGenuriCautate()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var listaGenuri = new List<Gen>();
                var listaCartiSolicitate = new List<Carte>();
                listaCartiSolicitate = getCartiSolicitate();
                foreach (var carte in listaCartiSolicitate)
                {
                    if (0 != listaGenuri.Count(x => x.GenId == carte.GenId))
                        continue;

                    listaGenuri.Add(context.Gens.FirstOrDefault(x => x.GenId == carte.GenId));
                }
                return listaGenuri;
            }
        }

        public List<Review> getReviews(Carte carte)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var listaReviewsReturnate = new List<Review>();
                var listaImprumuturi = new List<Imprumut>();
                listaImprumuturi = context.Imprumuts.Where(x => x.CarteId == carte.CarteId).ToList();

                foreach (var imprumut in listaImprumuturi)
                {
                    if (0 != context.Reviews.Where(x => x.ImprumutId == imprumut.ImprumutId).Count())
                        listaReviewsReturnate.Add(context.Reviews.FirstOrDefault(x => x.ImprumutId == imprumut.ImprumutId));
                }
                return listaReviewsReturnate;
            }
        }
    }
}
