using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones.Properties
{
   public class Operaciones
    {
        ///<sumary>
        ///Calcular la suma de uno de los elemntos de un array
        ///</sumary>sumary>
        ///<param name=""array"></param>
        ///<returns>double</returns>

        public double suma(double[] array)
        {
            double suma = 0;
            foreach (double x in array)
            {
                suma += x;
            }
            return suma;
        }

        public string fnSaludo(string nombrePersona)
        {
            return "Binvenido" + nombrePersona;

        }
    }
}







