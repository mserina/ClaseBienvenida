using ClaseBienvenida.Servicios;

namespace ClaseBienvenida{
    /// <summary>
    /// Clase principal de la aplicacion
    /// </summary>
    class Program
    {
        /// <summary>
        ///  Metodo de entrada a la aplicacion 
        ///  contiene el procedimiento de nuestra aplicacion
        ///  200923 - msm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Llamada al metodo que imprime el mensaje por consola

            MenuInterfaz menuInterfaz = new MenuImplementacion();

            menuInterfaz.mensajeBienvenida();
        }
    }
}