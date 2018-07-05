using DuffManCore.Data;
using DuffManCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuffManCore.Services
{
    public class SqlLitterData : ILitterData
    {
        private LitterDbContext _context;

        public SqlLitterData(LitterDbContext context)
        {
            _context = context;   
        }

        //public Litter Add(Litter litter)
        //{
        //    throw new NotImplementedException();
        //}

        public Litter Get(int id)
        {
            return _context.Litters.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<Litter> GetAll()
        {
            return _context.Litters.OrderBy(p => p.Id);
        }
    }
}
