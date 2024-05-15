using EX.Core.Domain;
using EX.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX.Core.Services
{
    public class LivreService : Service<Livre>, ILivreService
    {
        public LivreService(IUnitOfWork uow) : base(uow)
        {
        }

        public IList<Categorie> getCategories(Statut ss)
        {
            return GetAll()
                .Where(h => h.PretLivres
                .Any(h => h.MyAbonne.Statut == ss))
                .Select(h => h.MyCategorie)
                .Distinct()
                .ToList();
        }

        public Livre getlivre()
        {
            return GetAll()
                .OrderByDescending(h => h.PretLivres.Count)
                .First();

        }

        public IList<Livre> getlivredate(DateTime dd, DateTime df)
        {
            return GetAll()
                .Where(h => h.PretLivres
                .Any(h => h.DateDeubt >= dd && h.DateFin <= df))
                .ToList();
        }


    }
}
