namespace teach_BookingApp.Models
{
    using System.Data.Entity;

    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}