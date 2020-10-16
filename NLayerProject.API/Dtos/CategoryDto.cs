using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Dtos
{
    public class CategoryDto
    {
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
