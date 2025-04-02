using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridView
{
    internal class Acciones
    {
        List<Modelo> ListaAutos = new List<Modelo>
        {
            new Modelo(01, "Blanco", 2020, "Volvo", "Suecia"),
            new Modelo(02, "Negro", 2018, "Volkswagen", "Alemania"),
            new Modelo(03, "Azul", 2021, "Kia", "Corea del Sur"),
            new Modelo(04, "Gris", 2024, "Honda", "Japón"),
            new Modelo(05, "Rojo", 2025, "Mazda", "Japón")
        };
        public List<Modelo> MostrarInfo()
        {
            return ListaAutos;
        }
        Modelo a = new Modelo();
        public bool EliminarAuto(int matricula)
        {
            try
            {
                var objeteliminar = ListaAutos.Find(x => x.Matricula == matricula);
                if (objeteliminar != null)
                {
                    ListaAutos.Remove(objeteliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AgregarAuto(int matricula, string color, int año, string marca, string pais)
        {
            try
            {
                ListaAutos.Add(new Modelo(a.Matricula = matricula, a.Color = color, a.Año = año, a.Marca = marca, a.Pais = pais));
                    return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
