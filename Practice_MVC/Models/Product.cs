using System;
using System.Collections.Generic;

namespace Practice_MVC.Models
{
    public partial class Product
    {
        public Product()
        {
            Genres = new HashSet<Genre>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public int PublisherId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Price { get; set; }
        public int? Discount { get; set; }
        public string? Image { get; set; }

        public virtual Publisher Publisher { get; set; } = null!;

        public virtual ICollection<Genre> Genres { get; set; }
    }
}
