using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Interfaces.Fruits
{
    public class Banana : IFruit
    {
        public string Name
        {
            get { return "Banana"; }
        }

        public bool IsPeeled { get; private set; }

        public string Peel()
        {
            IsPeeled = true;
            return "You peel the banana";
        }
    }

    public class Orange : IFruit
    {
        public string Name
        {
            get { return "Orange"; }
        }

        public bool IsPeeled { get; private set; }


        public Orange() { }
        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            if (IsPeeled)
            {
                return "It's already peeled!";
            }
            else
            {
                IsPeeled = true;
                return "You peel the orange";
            }
        }
    }
}
