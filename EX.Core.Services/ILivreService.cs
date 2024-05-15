using EX.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Services
{
    internal interface ILivreService
    {
        Livre getlivre();
        IList<Livre> getlivredate(DateTime dd, DateTime df);
        IList<Categorie> getCategories(Statut ss);
    }
}
