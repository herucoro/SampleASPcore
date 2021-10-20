using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sample.Models;

namespace Sample.Data {
    public class TonerContext: DbContext {
        // public PersonContext(DbContextOptions<PersonContext> options) : base(options){}

        // Context.csは各テーブルの合体するものを設定する
        public DbSet<Toner>? Toner { get; set; }
        public DbSet<Printer> Printers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql("Host=db;Database=dev;Username=dev;Password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Toner>(entity => {
                entity.ToTable("toner");
                
                entity.HasKey(e => e.id);
                entity.Property(e => e.black).HasColumnName("black");
                entity.Property(e => e.magenta).HasColumnName("magenta");
                entity.Property(e => e.yellow).HasColumnName("yellow");
                entity.Property(e => e.cyan).HasColumnName("cyan");
                entity.Property(e => e.recovered_toner).HasColumnName("recovered_toner");
                entity.Property(e => e.drum).HasColumnName("drum");
            });

            modelBuilder.Entity<Printer>(entity => {
                entity.ToTable("printer");

                entity.HasKey(e => e.id);
            });


            base.OnModelCreating(modelBuilder);
        }
    }
}