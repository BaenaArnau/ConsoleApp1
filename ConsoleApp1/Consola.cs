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
        enum DiaSemana
        {
            lunes,
            martes,
            miercoles,
            jueves,
            viernes,
            sabado,
            domingo
        }

        static void Main(string[] args)
        {
            bool bucle = true;

            while (bucle)
            {
                int valorMenu;
                
                Menu();
                bool funciona = int.TryParse(Console.ReadLine(), out valorMenu);

                if (funciona)
                {
                    switch (valorMenu)
                    {
                        case 1:
                            ConvertorDeUpAndDown();
                            break;
                        case 2:
                            ComparadorFecha();
                            break;
                        case 3:
                            Polidromo();
                            break;
                        case 4:
                            Potencia();
                            break;
                        case 5:
                            Dividir();
                            break;
                        case 6:
                            ComparadorDeTexto();
                            break;
                        case 7:
                            InvertirsionTexto();
                            break;
                        case 8:
                            CalcularMedia();
                            break;
                        case 9:
                            InvertirNumero();
                            break;
                        case 10:
                            AdivinaElNumero();
                            break;
                        case 11:
                            NumerosPares();
                            break;
                        case 12:
                            PreguntarDiaDeLaSemana();
                            break;
                        case 0:
                            bucle = false;
                            break;
                        default:
                            Console.WriteLine("Introduzca una opcion valida");
                            break;
                    }
                }
                else
                    Console.WriteLine("Introduzca un numero");
                
            }
        }

        public static void Menu()
        {
            Console.WriteLine(@"
1.      Comvertor de texto a CamelCase o LowerCase
2.      Comparador de fechas
3.      Comprobar si una palabra es un polidromo
4.      Calcular potencia
5.      Dividir
6.      Comparar text alfabeticamente
7.      Invertir un texto
8.      Calcula la media
9.      Invertir numero
10.     Juego de divinar el numero
11.     Encunetra numero pares hasta el 20
12.     Comversor a dia de la semana

Presiona 0 para salir");
        }

        public static void ConvertorDeUpAndDown()
        {
            String cadena;
            int opciones;

            Console.WriteLine("Inserte la cadena de texto");
            cadena = Console.ReadLine();
            Console.WriteLine(@"
1.      Pasar el texto a CamelCase
2.      Pasar el texto a LowerCase");
            opciones = int.Parse(Console.ReadLine());

            switch (opciones)
            {
                case 1:
                    Console.WriteLine(CamelAndLower(cadena, true));
                    break;
                case 2:
                    Console.WriteLine(CamelAndLower(cadena, false));
                    break;
                default:
                    Console.WriteLine("Introduzca una opcion valida");
                    break;
            }
        }

        public static string CamelAndLower(string cadena,bool camel)
        {
            string nuevaCadena = "";
            bool letra = false;
            if (camel)
            {
                foreach (char caracter in cadena)
                {

                    if (caracter.Equals(' ')) 
                        letra = true;
                    else if (letra == true)
                    {
                        nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                        letra = false;
                    }
                    else if (letra == false) 
                        nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                }

            }
            else
            {
                foreach (char caracter in cadena)
                {

                    if (caracter.Equals(' ')) letra = true;
                    else if (letra == true)
                    {
                        nuevaCadena = nuevaCadena + Char.ToLower(caracter);
                        letra = false;
                    }
                    else if (letra == false) nuevaCadena = nuevaCadena + Char.ToUpper(caracter);
                }
            }

            return nuevaCadena;
        }

        public static void ComparadorFecha()
        {
            bool igual = false;

            Console.WriteLine("Escriba la primera fecha a continuacion (ej: MM/dd/yyyy)");
            string fecha1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda fecha a continuacion (ej: MM/dd/yyyy)");
            string fecha2 = Console.ReadLine();

            if (fecha1.Length == 10 && fecha2.Length == 10)
            {
                if (fecha1[9] == fecha2[9] && fecha1[8] == fecha2[8] && fecha1[7] == fecha2[7] && fecha1[6] == fecha2[6])
                {
                    if (fecha1[4] == fecha2[4] && fecha1[3] == fecha2[3])
                    {
                        if (fecha1[1] == fecha2[1] && fecha1[0] == fecha2[0])
                        {
                            igual = true;
                        }
                    }
                }

                if (igual)
                {
                    Console.WriteLine("Las dos fechas son iguales");
                }
                else
                {
                    Console.WriteLine("Las dos fechas no son iguales");
                }
            }
            else
            {
                Console.WriteLine("Introduzca un formato correcto");
            }
        }

        public static void Polidromo()
        {
            string entrada;
            bool polidromo = false;

            Console.WriteLine("Escriba la palabra a continuacion:");
            entrada = Console.ReadLine().ToLower();

            polidromo = ComparacionDeCaracteres(entrada);

            if (polidromo) 
                Console.WriteLine("La palabra " + entrada + " es un polinomio");
            else 
                Console.WriteLine("La palabra " + entrada + " no es un polinomio");
        }

        private static bool ComparacionDeCaracteres(string entrada)
        {
            for (int i = 0; i < entrada.Length; i++)
            {
                if (entrada[i] != entrada[entrada.Length-i-1]) 
                    return false; 
            }
            return true;
        }

        public static void Potencia()
        {
            int numero, potencia, resultado;

            Console.WriteLine("Numero a multiplicar: ");
            numero = int.Parse(Console.ReadLine());
            resultado = numero;
            Console.WriteLine("Numero de la potencia: ");
            potencia = int.Parse(Console.ReadLine());

            for (int i = 0; i < potencia; i++)
            {
                resultado = resultado * numero;
            }

            Console.WriteLine("Resultado: " + resultado);
        }

        public static void Dividir()
        {
            Console.WriteLine("Introduzca el numerador");
            int numerador = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el denominador");
            int denominador = int.Parse(Console.ReadLine());

            Console.WriteLine("Resultado: " + ComparadorDivisores(numerador, denominador));
        }

        public static int ComparadorDivisores(int numerador, int denominador)
        {
            int contador = 1;

            while (true)
            {
                if (numerador > denominador)
                {
                    numerador = numerador - denominador;
                    contador++;
                }
                else
                {
                    return contador;
                }
            }
        }

        public static void ComparadorDeTexto()
        {
            Console.WriteLine("Escriba la primera palabra");
            string palabra1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda palabra");
            string palabra2 = Console.ReadLine();

            Console.WriteLine(ComparadorDePalabras(palabra1, palabra2));
        }

        public static bool ComparadorDePalabras(string palabra1, string palabra2)
        {
            if (palabra1.Length <= palabra2.Length)
            {
                for (int i = 0; i < palabra2.Length; i++)
                {
                    if (palabra1[i] != palabra2[i])
                    {
                        if (palabra1[i] > palabra2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else
            {
                for (int i = 0; i < palabra1.Length; i++)
                {
                    if (palabra1[i] != palabra2[i])
                    {
                        if (palabra1[i] > palabra2[i])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }

        public static void InvertirsionTexto()
        {
            Console.WriteLine("Escriba el texto que quiere invertir");
            string entrada = Console.ReadLine();
            string salida = "";

            for (int i = entrada.Length - 1; i >= 0; i--)
            {
                salida = salida + entrada[i];
            }

            Console.WriteLine(salida);
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Introduzca los numero separados por comas (ej: 1,2,3,4)");
            int[] listaDeNumeros;

            try
            {
                listaDeNumeros = Array.ConvertAll(Console.ReadLine().Trim().Split(','), Convert.ToInt32);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            int resultado = 0;

            for (int i = 0; i < listaDeNumeros.Length; i++)
            {
                resultado = resultado + listaDeNumeros[i];
            }

            resultado = resultado / listaDeNumeros.Length;

            Console.WriteLine(resultado);
        }

        public static void InvertirNumero()
        {
            Console.WriteLine("Escriba el numero a invertir");
            bool funciona = int.TryParse(Console.ReadLine(), out int numero);
            int longitudDelNumero = (int)Math.Floor(Math.Log10(numero));
            int ultimoDigito;
            int resultado = 0;

            if (funciona)
            {
                for (int i = 0; i < longitudDelNumero; i++)
                {
                    ultimoDigito = numero % 10;
                    numero = numero / 10;
                    resultado = (resultado * 10) + ultimoDigito;
                }

                Console.WriteLine("Numero invertido: " + resultado);
            }
            else
                Console.WriteLine("Introduzca un numero");
        }

        public static void AdivinaElNumero()
        {
            Console.WriteLine("Generando numero...");

            Random random = new Random();
            int numeroRandom = random.Next(1, 20);

            Console.WriteLine("Numero generado empezando juego");

            while (true)
            {
                Console.WriteLine("Introduzca un numero");
                bool funciona = int.TryParse(Console.ReadLine(), out int entrada);

                if (funciona)
                {
                    if (entrada < numeroRandom)
                        Console.WriteLine("El numero es mas grande");
                    else if (entrada > numeroRandom)
                        Console.WriteLine("El numero es mas pequeño");
                    else
                    {
                        Console.WriteLine("Has encontrado el numero");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Escriba un valor valido");
                }
            }
        }

        public static void NumerosPares()
        {
            Console.WriteLine(@"
Elige que tipo de bucle quieres usar:

1.      Utilizar un for
2.      Utilizar un while
3.      Utilizar un do/while

Escriba 0 para salir de programa");

            bool funciona = int.TryParse(Console.ReadLine(), out int opcion);

            if (funciona)
            {
               NumerosPares(opcion);
            }
        }

        public static void NumerosPares(int opcion)
        {
            int contador = 1;
            switch (opcion)
            {
                case 1:
                    for (int i = 1; i < 20; i++)
                    {
                        if (i % 2 == 0)
                            Console.WriteLine(i);
                    }
                    break;
                case 2:
                    while (contador < 20)
                    {
                        if (contador % 2 == 0)
                            Console.WriteLine(contador);
                        if (contador == 20)
                            break;

                        contador++;
                    }
                    break;
                case 3:
                    do
                    {
                        if (contador % 2 == 0)
                            Console.WriteLine(contador);
                        contador++;
                    } while (contador < 20);
                    break;
                case 0:
                    break;
            }
        }

        public static void PreguntarDiaDeLaSemana()
        {
            string entrada;
            DiaSemana dia = new DiaSemana();

            Console.Write("Escriba el dia de la semana: ");
            entrada = Console.ReadLine();

            if (DiaSemana.TryParse(entrada.ToLower(), out dia))
            {
                Console.WriteLine("El dia de la semana es " + (dia.GetHashCode() + 1));
            }

            Console.WriteLine("Escriba una opcion valida");
        }

    }
}