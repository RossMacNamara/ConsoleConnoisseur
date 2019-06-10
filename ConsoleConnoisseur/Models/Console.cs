using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleConnoisseur.Models
{
    public class Console
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public int Released { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public string ImgUrl { get; set; }
        public string ImgThumbnailUrl { get; set; }
    }
}
