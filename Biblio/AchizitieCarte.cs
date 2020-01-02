using Biblio.Context;
using System.Linq;

namespace Biblio
{
    public class AchizitieCarte
    {
        public int getGenIdByName(string descriere)
        {
            var genId = 0;
            bool exista = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                var gens = context.Gens;
                foreach (var g in gens)
                {
                    if (g.Descriere.Equals(descriere))
                    {
                        genId = g.GenId;
                        exista = true;
                        break;
                    }
                }
                if (!exista)
                {
                    Gen g = new Gen() { Descriere = descriere };
                    context.Gens.Add(g);
                    context.SaveChanges();

                    var gen = context.Gens.FirstOrDefault(x => x.Descriere.Equals(descriere));
                    genId = gen.GenId;
                }

            }
            return genId;
        }

        public int getAutorIdByName(string nume, string prenume)
        {
            var autorId = 0;
            bool exista = false;
            using (DatabaseContext context = new DatabaseContext())
            {
                var autors = context.Autors;
                foreach (var a in autors)
                {
                    if (a.Nume.Equals(nume) && a.Prenume.Equals(prenume))
                    {
                        autorId = a.AutorId;
                        exista = true;
                        break;
                    }
                }
                if (!exista)
                {
                    Autor a = new Autor()
                    {
                        Nume = nume,
                        Prenume = prenume
                    };
                    context.Autors.Add(a);
                    context.SaveChanges();

                    var autor = context.Autors.FirstOrDefault(x => x.Nume.Equals(nume) && x.Prenume.Equals(prenume));
                    autorId = autor.AutorId;
                }

            }
            return autorId;
        }

        public void achizitie(string titluCarte, string descrieGen, string numeAutor, string prenumeAutor, int numar_de_inserari)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var autorId = getAutorIdByName(numeAutor, prenumeAutor);
                var genId = getGenIdByName(descrieGen);
                for(int i = 0; i < numar_de_inserari; i++)
                {
                    Carte c = new Carte()
                    {
                        AutorId = autorId,
                        GenId = genId,
                        Titlu = titluCarte
                    };
                    context.Cartes.Add(c);
                    context.SaveChanges();
                }
            }
        }
    }
}
