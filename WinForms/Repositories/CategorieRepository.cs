using System.Collections.Generic;
using System.Linq;
using StockLibrary.Context;
using StockLibrary.Entities;

namespace StockLibrary.Repositories
{
    public class CategorieRepository
    {
        private readonly AppDbContext _context;

        public CategorieRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorie> GetAll() => _context.Categories.ToList();

        public void Add(Categorie cat)
        {
            _context.Categories.Add(cat);
            _context.SaveChanges();
        }

        public void Update(Categorie cat)
        {
            _context.Categories.Update(cat);
            _context.SaveChanges();
        }
        public void Delete(Categorie cat)
        {
            _context.Categories.Remove(cat);
            _context.SaveChanges();
        }

    }
}
