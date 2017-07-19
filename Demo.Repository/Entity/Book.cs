using System.Globalization;

namespace Demo.Repository.Entity
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Self
        {
            get { return string.Format(CultureInfo.CurrentCulture, "api/books/{0}", this.Id); }
            set { }
        }
    }
}