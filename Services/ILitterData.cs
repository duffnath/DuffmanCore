using DuffManCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuffManCore.Services
{
    public interface ILitterData
    {
        IEnumerable<Litter> GetAll();
        Litter Get(int id);
        //Litter Add(Litter litter);
    }
}
