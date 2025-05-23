using System.Drawing;

namespace Ejercicio1_guia
{
    internal class Program
    {
        static int contador;
        static int acumulador;
        static int maximo;
        static int minimo;

        static void RegistrarValor(int valor)
        {
            acumulador = acumulador+ valor;
            contador=contador+1;

        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
            {
                promedio= 1.0*acumulador/contador;
            }
            return promedio;
        }
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio1 - ingrese 1,2,3 segun menú");
            Console.WriteLine("1- Procesar un solo número");
            Console.WriteLine("2- Procesar varios números");
            Console.WriteLine("3- Mostrar máximo y mínimo");
            Console.WriteLine("4- Mostrar promedio");

            int op = Convert.ToInt32( Console.ReadLine() );

            return op;
        }

        static void MostrarPantallaSolicitudNumero()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio1 - solicitud de un solo número");


            int numero = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(numero);
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {

            Console.Clear();
            Console.WriteLine("Ejercicio1 - calcular promedio");

            double promedio = CalcularPromedio();

            Console.WriteLine($"Promedio: {promedio}");

            Console.WriteLine("Presione cualquier tecla para volver al menú principal.");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != -1)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitudNumero();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    default:
                        op = -1;
                        break;
                }

                if (op != -1)
                {
                    op = MostrarPantallaSolicitarOpcionMenu();
                }
            }
        }
    }
}
