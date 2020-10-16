using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Dtos
{
    public class ProductwithCategoryDto:ProductDto
    {
        public  CategoryDto Category { get; set; }
    }
}
