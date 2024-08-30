using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Consola
    {
        static void Main(string[] args)
        {

            String cadena;
            String nuevaCadena;
            bool mayuscula;
            bool minuscula;
            string opciones;

            while (true)
            {

                nuevaCadena = "";
                mayuscula = true;
                minuscula = true;

                Console.WriteLine("Inserte la cadena de texto");
                cadena = Console.ReadLine();
                Console.WriteLine("Quieres pasarlo a CamelCase o LowerCase");
                opciones = Console.ReadLine();

                if (opciones.ToLower().Equals("camelcase"))
                {

                    foreach (char caracter in cadena)
                    {

                        if (caracter.Equals(' ')) mayuscula = true;
                        else if (mayuscula == true)
                        {
                            nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                            mayuscula = false;
                        }
                        else if (mayuscula == false) nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                        
                    }

                    Console.WriteLine(nuevaCadena);
                }
                else if (opciones.ToLower().Equals("lowercase"))
                {

                    foreach (char caracter in cadena)
                    {

                        if (caracter.Equals(' ')) minuscula = true;
                        else if (minuscula == true)
                        {
                            nuevaCadena = nuevaCadena+ Char.ToLower(caracter);
                            minuscula = false;
                        }
                        else if (minuscula == false) nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                    }

                    Console.WriteLine(nuevaCadena);
                }
                else Console.WriteLine("Introduzca una opcion valida");
            }
        }
    }
}