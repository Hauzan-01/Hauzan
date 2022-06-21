using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("Chef making chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("Chef making salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef is cooking noodles!");
        }
    }
}
