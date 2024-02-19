using Main.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main.Business.Abstract
{
    public interface IManager<T>
    {
        List<T> GetAll();
        void Add(T add);
        void Remove(T remove);
    }
}
