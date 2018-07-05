using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DuffManCore.Models;

namespace DuffManCore.Services
{
    public class FakeLitterData : ILitterData
    {
        public FakeLitterData()
        {
            _litters = new List<Litter>
            {
                new Litter { Id = 1, Name = "Sadie litter 1", FatherName = "Leonitis", PuppyCount = 9},
                new Litter { Id = 2, Name = "Becca litter 1", FatherName = "Sparticus", PuppyCount = 14}
            };
        }

        List<Litter> _litters;

        public Litter Get(int id)
        {
            return _litters.FirstOrDefault(l => l.Id == id);
        }

        public IEnumerable<Litter> GetAll()
        {
            return _litters.OrderBy(l => l.Name);
        }
    }
}
