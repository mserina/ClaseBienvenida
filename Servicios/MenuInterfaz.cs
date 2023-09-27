using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseBienvenida.Servicios
{
    /// <summary>
    /// Interfaz que corresponde a toda las acciones que se pueden hacer desde el menu
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Muestra el mensaje de bienvenida
        /// 200923 - msm
        /// </summary>
        public void mensajeBienvenida();
    }
}
