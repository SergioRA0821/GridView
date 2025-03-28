using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Modelo : Auto
    {
        public Modelo(int matricula, string color, int año, string marca, string pais)
        : base(matricula, color)
        {
            Año = año;
            Marca = marca;
            Pais = pais;
        }
        public Modelo() { }

        public int Año { get; set; }
        public string Marca { get; set; }
        public string Pais { get; set; }
    }
}
