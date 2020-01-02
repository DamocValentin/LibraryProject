using System.Data.Entity;

namespace Biblio.Context
{
    internal class DatabaseContext : ModelContainer
    {
        public DatabaseContext()
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Carte>()
                .HasRequired(a => a.Autor)
                .WithMany(c => c.Cartes)
                .HasForeignKey(a => a.AutorId);

            modelBuilder.Entity<Imprumut>()
                .HasRequired(a => a.Cititor)
                .WithMany(i => i.Imprumuts)
                .HasForeignKey(c => c.CititorId);

            modelBuilder.Entity<Review>()
                 .HasRequired(i => i.Imprumut)
                 .WithMany(r => r.Reviews)
                 .HasForeignKey(i => i.ImprumutId);

            modelBuilder.Entity<Imprumut>()
                .HasRequired(c => c.Carte)
                .WithMany(i => i.Imprumuts)
                .HasForeignKey(c => c.CarteId);

            modelBuilder.Entity<Carte>()
                .HasRequired(g => g.Gen)
                .WithMany(c => c.Cartes)
                .HasForeignKey(g => g.GenId);
        }
    }
}
