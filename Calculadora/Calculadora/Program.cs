using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            string operacion = "";
            string decision = "";
            List<float> resultados = new List<float>();
            do
            {
                Console.WriteLine("Ingrese la operación que desea realizar. Elija:\n+: Suma\n-: Resta");
                do
                {
                    operacion = Console.ReadLine();
                    if (operacion != "+" && operacion != "-")
                    {
                        Console.WriteLine("No ha ingresado una operación válida.");
                    }
                } while (operacion != "+" && operacion != "-");
                do
                {
                    Console.WriteLine("Ingrese el primer término de la operación:");
                    if (!float.TryParse(Console.ReadLine(), out a))
                    {
                        a = 0;
                    }
                    if (a == 0)
                    {
                        Console.WriteLine("El valor ingresado no es válido.\nRecuerde no ingresar 0, puesto que la operación no tendría sentido.");
                    }
                } while (a == 0);
                do
                {
                    Console.WriteLine("Ingrese el segundo término de la operación:");
                    if (!float.TryParse(Console.ReadLine(), out b))
                    {
                        b = 0;
                    }
                    if (b == 0)
                    {
                        Console.WriteLine("El valor ingresado no es válido.\nRecuerde no ingresar 0, puesto que la operación no tendría sentido.");
                    }
                } while (b == 0);
                if (operacion == "+")
                {
                    float resultado = a + b;
                    Console.WriteLine("El resultado es: " + resultado);
                    resultados.Add(resultado);
                }
                else if (operacion == "-")
                {
                    float resultado = a - b;
                    Console.WriteLine("El resultado es: " + resultado);
                    resultados.Add(resultado);
                }
                Console.WriteLine("¿Desea realizar otra operación? S/N:");
                do
                {
                    decision = Console.ReadLine().ToUpper();
                    if (decision != "S" && decision != "N")
                    {
                        Console.WriteLine("La elección es inválida. Debe indicar S o N.");
                    }
                } while (decision != "S" && decision != "N");
            } while (decision != "N");
            if (resultados.Count < 2)
            {
                Console.WriteLine("Para mostrar la lista de resultados se requiere haber realizado al menos 2 operaciones.");
            }
            else
            {
                Console.WriteLine("Los resultados ingresados son:");
                for (int i = 0; i < resultados.Count; i++)
                {
                    Console.WriteLine(resultados[i]);
                }
            }
            Console.WriteLine("Pulse cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
