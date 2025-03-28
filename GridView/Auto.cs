using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Auto
    {
        public Auto(int matricula, string color)
        {
            Matricula = matricula;
            Color = color;
        }
        public Auto() { }

        public int Matricula { get; set; }
        public string Color { get; set; }
    }
}
