using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;
using StevensGameCorner.Models;

namespace StevensGameCorner.Data
{
    public class StevensGameCornerContext : DbContext
    {
        public StevensGameCornerContext(DbContextOptions<StevensGameCornerContext> options) : base(options)
        { }
        public DbSet<StevensGameCorner.Models.ProductModel>? ProductModel { get; set; }
        public DbSet<StevensGameCorner.Models.ContactModel>? ContactModel { get; set; }
        //public DbSet<ProductDb> Products { get; set; } = null!;
        //public DbSet<ContactDb> Contacts { get; set; } = null!;
    }
}
//Use ProductDb for your DbSet entity type to store the products in the database
//(use page 141 as a guide for writing the code for the DbContext class for your project).
//Use ContactDb for the DbSet entity type to store the contact information in the database.
//Be sure the name of your DbContext class reflects your project name to avoid errors.
//We will add the links to our navbar in a later step. Our link names will be ContactDb
//and ProductDb.
