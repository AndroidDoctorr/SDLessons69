using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruits
{
    public interface IFruit
    {
        string Name { get; }
        bool IsPeeled { get; }
        string Peel();
    }
}
