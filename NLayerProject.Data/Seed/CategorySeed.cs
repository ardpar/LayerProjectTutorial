﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerProject.Core.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLayerProject.Data.Seed
{
    class CategorySeed : IEntityTypeConfiguration<Category>
    {
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { id = _ids[0], Name = "Kalemler" },
                new Category { id = _ids[1], Name = "Defterler" }
                );
        }
    }
}