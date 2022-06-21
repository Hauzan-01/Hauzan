using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The chef is making pasta.");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef is cooking Pizza!");
        }
    }
}
