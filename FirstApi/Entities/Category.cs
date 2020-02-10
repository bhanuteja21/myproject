using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstApi.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDetails { get; set; }
    }
    public class CategoryMaping : IEntityTypeConfiguration<Category>
    {
       
public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Id).UseSqlServerIdentityColumn();
            builder.HasKey(p => p.Id);
            builder.Property(p => p.CategoryName);
            builder.Property(p => p.CategoryDetails);
            builder.ToTable("T_ELITE_CAT");
        }
    }
}
