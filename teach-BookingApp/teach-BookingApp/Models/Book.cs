namespace teach_BookingApp.Models
{
    /// <summary>
    /// Модель книги
    /// </summary>
    public class Book
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        public string Autor { get; set; }

        public int Year { get; set; }
    }
}