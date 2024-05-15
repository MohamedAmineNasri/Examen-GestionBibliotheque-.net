using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Domain
{
    public class Livre
    {
        [Required]
        public string Isbn { get; set; }
        public string Titre { get; set; }
        public int LivreId { get; set; }
        public int NbrExemplaires {  get; set; }
        public string Auteur {  get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }
        
        public virtual Categorie MyCategorie { get; set; }
        public  virtual IList<PretLivre> PretLivres { get; set; }

        public int categfk { get; set; }

    }
}
