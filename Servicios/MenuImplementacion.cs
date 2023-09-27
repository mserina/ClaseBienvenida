using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    /// <summary>
    /// Implementacion de las acciones del menu
    /// 200923 - msm
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido";

            Console.WriteLine(mensaje);
        }
    }   
}
