using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace NLayerProject.Core.Model
{
    public class Category
    {
        public Category()
        {
            Products = new Collection<Product>();
        }
        public int id { get; set; }
        public string Name { get; set; }
        public bool isDeleted { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
