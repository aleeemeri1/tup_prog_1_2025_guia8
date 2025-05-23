using System.ComponentModel;

namespace Ejercicio1_con_metodos
{
    internal class Program
    {
        static int contador;
        static int acumulador;
        static int cantidad;
        static int valor;
        static int maximo;
        static int minimo;

        static void InicializarVariables()
        {
            contador = 0;
            acumulador = 0;
        }

        static void SolicitarCantidadIngresos()
        {
            Console.WriteLine("Ingrese la cantidad de ingresos");
            cantidad = Convert.ToInt32(Console.ReadLine());
        }

        static void RegistrarValor(int valor)
        {
            acumulador = acumulador + valor;
            contador++;

            if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }

            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }

        }

        static double CalcularPromedio()
        {
            double promedio = 0;

            if (contador > 0)
                promedio =1d* acumulador / contador;

            return promedio;
        }

      

        static void Main(string[] args)
        {
            InicializarVariables();

            SolicitarCantidadIngresos();

            for (int n = 1; n < cantidad; n++)
            {
                Console.WriteLine("Ingresa un valor:");
                valor = Convert.ToInt32(Console.ReadLine());
               
                RegistrarValor(valor);
            }



            if (cantidad > 0)
            {
                double promedio = CalcularPromedio();
                Console.WriteLine($"Promedio: {promedio:f2}");
            }
            else
            {
                Console.WriteLine("No hubo valores ingresados");
            }
        }
    }
}
