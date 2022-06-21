using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject
{
    internal class ItalianChef: Chef
    {
        private string specialDish { get; set; }

        public string SpecialDish
        {
            set { specialDish = value; }
            get { return specialDish; }
        }
    }
}
