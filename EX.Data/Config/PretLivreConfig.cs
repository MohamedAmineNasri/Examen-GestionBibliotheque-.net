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
    internal class PretLivreConfig : IEntityTypeConfiguration<PretLivre>
    {
        public void Configure(EntityTypeBuilder<PretLivre> builder)
        {
            builder
                .HasOne(r => r.MyLivre)
                .WithMany(p => p.PretLivres)
                .HasForeignKey(r => r.LivreFk)
                .OnDelete(DeleteBehavior.Cascade);

            builder
               .HasOne(r => r.MyAbonne)
               .WithMany(p => p.PretLivres)
               .HasForeignKey(r => r.AbonneFk)
               .OnDelete(DeleteBehavior.Cascade);


            builder.HasKey(r => new
            {
                r.DateDeubt,
                r.AbonneFk,
                r.LivreFk
            });
        }
    }
}
