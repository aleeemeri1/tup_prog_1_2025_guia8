namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region declaración de variables
            int contador, acumulador;
            int cantidad;
            int valor;
            #endregion

            #region iniciar contador y acumulador
            contador = 0;
            acumulador = 0;
            #endregion

            #region solicitar cantidad de ingresos
            Console.WriteLine("Ingrese la cantidad de ingresos");
            cantidad = Convert.ToInt32( Console.ReadLine());
            #endregion
            for (contador=1,contador<cantidad, contador++ )
            {
                Console.WriteLine("Ingresa un valor:");
                valor = Convert.ToInt32(Console.ReadLine());

            }

        }
    }
}
