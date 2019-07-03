using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IOperario
    {
        decimal CalcularJornal(int horas);
        string Descripcion { get; }

    }

    public class JefeDeEquipo : IOperario
    {
        public decimal CalcularJornal(int horas)
        {

            return 3000M;
        }
            
        public string Descripcion { get; set; }

        public JefeDeEquipo(string nom, string ape)
        {
            Descripcion = $"{nom} {ape}, Jefe de Equipo";
        }
       
    }

    public class Tecnico : IOperario
    {
        public decimal CalcularJornal(int horas)
        {
            if (horas > 6)
            {
                return (800 * horas) + 100;
            }

            else
            {
                return 800 * horas;
            }
        }

        public string Descripcion { get; set; }

        public Tecnico(string nom, string ape)
        {
            Descripcion = $"{nom} {ape}, Tecnico"; //Lo seteas desde el constructor, obligás a mandar parámetros cuando se quiera crear un obj de éste
        }

    }

    public class operario : IOperario
    {
        public decimal CalcularJornal(int horas)
        {
            return 800 + (50 * horas);                       
        }

        public string Descripcion { get; set; }

        public operario(string nom, string ape)
        {
            Descripcion = $"{nom} {ape}, Tecnico"; //Lo seteas desde el constructor, obligás a mandar parámetros cuando se quiera crear un obj de éste
        }

    }


}
