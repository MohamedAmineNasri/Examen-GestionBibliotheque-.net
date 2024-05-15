using EX.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Data.Config
{
    internal class CategorieConfig : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.HasMany(h => h.Livres)
                .WithOne(p=>p.MyCategorie)
                .HasForeignKey(h => h.categfk)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
