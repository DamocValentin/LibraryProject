using System;
using System.Linq;
using Biblio.Context;

namespace Biblio
{
    public class RestituireCarte
    {
        public void restituire(string numeCarte, string numeAutor, string prenumeAutor, string numeCititor, string prenumeCititor, string textReview)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var cititorId = context.Cititors.FirstOrDefault(x => x.Nume.Equals(numeCititor) && x.Prenume.Equals(prenumeCititor)).CititorId;
                var carteId = context.Cartes.FirstOrDefault(x => x.Titlu.Equals(numeCarte) &&
                                                                 x.AutorId == context.Autors.FirstOrDefault(y => y.Nume.Equals(numeAutor) && y.Prenume.Equals(prenumeAutor)).AutorId).CarteId;

                var imprumut = context.Imprumuts.FirstOrDefault(x => x.CititorId == cititorId && x.CarteId == carteId);
                imprumut.DataRestituire = DateTime.Now;
                context.SaveChanges();

                var imprumutId = context.Imprumuts.FirstOrDefault(x => x.CititorId == cititorId && x.CarteId == carteId).ImprumutId;
                Review review = new Review()
                {
                    ImprumutId = imprumutId,
                    Text = textReview
                };
                context.Reviews.Add(review);
                context.SaveChanges();
            }

        }
    }
}
