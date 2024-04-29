using System.ComponentModel.DataAnnotations;

namespace E_Books.Models
{
    public class Item

    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

       [Display(Name = "Availability")]
        public bool IsAvailable { get; set; }

    }
}

