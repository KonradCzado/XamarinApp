using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public byte[] ImageToDisplay { get; set; }
        public Producer Producer { get; set; }
    }
}
