using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Domain
{
    public class Categorie
    {
        [Key]
        public int Code { get; set; }
        public string Libelle { get; set; }
        public virtual IList<Livre> Livres { get; set; }
    }
}
