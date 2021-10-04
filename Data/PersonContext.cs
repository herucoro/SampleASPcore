using Microsoft.EntityFrameworkCore;
using Sample.Models;

namespace Sample.Data {
    public class PersonContext: DbContext {
        public PersonContext(DbContextOptions<PersonContext> options) : base(options){}

        public DbSet<Person>? Persons { get; set; }
        
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        //     base.OnConfiguring(optionsBuilder);
        //     optionsBuilder.UseNpgsql("Host=db;Database=dev;Username=dev;Password=password");
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Person>(entity => {
                entity.ToTable("person");

                entity.HasKey(e => e.id);

                entity.Property(e => e.id)
                .HasColumnName("id");                

                entity.Property(e => e.name)
                .HasColumnName("name");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}