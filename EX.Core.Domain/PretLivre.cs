using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Domain
{
    public class PretLivre
    {
        public DateTime DateFin {  get; set; }
        public DateTime DateDeubt { get; set;}

        public virtual Livre MyLivre { get; set; }
        public virtual Abonne MyAbonne { get; set; }

        public int LivreFk { get; set; }
        public int AbonneFk { get; set; }
    }
}
