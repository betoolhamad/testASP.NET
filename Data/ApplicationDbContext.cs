using  Microsoft.EntityFrameworkCore;
using Myexam.Models;

namespace Myexam.Data {
public class ApplicationDbContext:DbContext{

    public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options) {}

            public DbSet<Categories> categories {get; set;}
            public DbSet<CategoriesTransportation> categoriesTransportation {get; set;}

            public DbSet<FootballTabels> footballTabels {get; set;}

            public DbSet<Hotels> hotels {get; set;}

            public DbSet<Stadiums> stadiums {get; set;}


            public DbSet<Transportation> transportation {get; set;}

}
}