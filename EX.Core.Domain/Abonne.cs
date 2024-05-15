using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Domain
{
    public enum Statut
    {
        Etud,Ens,Autre
    }
    public class Abonne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Id { get; set;}
        public Statut Statut { get; set;}
        public string Adresse { get; set;}
        public string Email { get; set;}
        public DateTime DateCrearion { get; set;}
        public virtual IList<PretLivre> PretLivres { get; set; }
    }
}
