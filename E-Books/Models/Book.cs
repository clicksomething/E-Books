using System.Drawing;


namespace E_Books.Models
{

    public class Book : Item

    {

        public string Author { get; set; }

        public string Publisher { get; set; }

        public string Category { get; set; }

        public string? Description { get; set; }

        public byte[]? Cover { get; set; }
        
    }
}
