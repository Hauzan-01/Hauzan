using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject
{
    internal class Chef
    {
        private string name { get; set; }
        private string nationality { get; set; }
        private string description { get; set; }

        public string Name
        {
            set { name = value; }   
            get { return name; } 
        }

        public string Nationality
        {
            set { nationality = value; }    
            get { return nationality; }
        }

        public string Description
        {
            set { description = value; }
            get { return description; }
        }
    }
}
