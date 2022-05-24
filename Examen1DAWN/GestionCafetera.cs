using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1DAWN
{
    /// <summary>
    /// Clase que se encarga de comprobar el funcionamiento de 
    /// la clase Cafetera probando sus métodos
    /// </summary>
    /// <remarks>Esta clase se asemeja a una main program</remarks>
    class GestionCafetera
    {
        static void main()
        {

            Cafetera mi_cafetera_ejemplo = new Cafetera("EspressoBarista", "Procoffee", 0.6, 7);

            Console.WriteLine(mi_cafetera_ejemplo.CantidaAgua);
            Console.WriteLine(mi_cafetera_ejemplo.TotalDeCapsulas);
            Console.WriteLine(mi_cafetera_ejemplo.ComprobarRealizacionCafe(5));
            Console.WriteLine(mi_cafetera_ejemplo.CantidaAgua);
            mi_cafetera_ejemplo.llenardep(0.5);
            Console.WriteLine(mi_cafetera_ejemplo.CantidaAgua);
            mi_cafetera_ejemplo.reponercapsulas(3);
            Console.WriteLine(mi_cafetera_ejemplo.TotalDeCapsulas);
        }
    }
}
