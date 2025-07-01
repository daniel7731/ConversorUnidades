using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorUnidades
{
    internal class Program
    {
        public static void imprimirMenu()
        {
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("1. Convertir metros a centimeros");
            Console.WriteLine("2. Convertir centimetros a metros");
            Console.WriteLine("3. Convetir metros a kilometros");
            Console.WriteLine("4. Convertir Kilometros a metros");
            Console.WriteLine("0. Finalizar");
        }
        public static double leerNumero(String line)
        {
            double numero = 0;
            try
            {
               numero    = Double.Parse(line);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine ("Formato invalido");
                return -1;
            }
            return numero;
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bievenido al conversor de unidades");
            while (true) {
                imprimirMenu();
                String line = Console.ReadLine();
                line = line.Trim();
                if ("1".Equals(line)) {

                    Console.Write("Ingresa la cantida de metros : ");
                    String input= Console.ReadLine();
                    double numero = leerNumero(input);
                    if ( numero < 0)
                    {
                        Console.WriteLine("Por favor ingresa un numero positivo!");
                    }
                    else
                    {
                        double centimetros = numero * 100;
                        Console.WriteLine($"{numero} metros  = {centimetros} centimetros");
                    }
                }
                if ("2".Equals(line))
                {
                    Console.Write("Ingresa la cantidad de centimetros : ");
                    String input = Console.ReadLine();
                    double numero = leerNumero(input);
                    if (numero < 0)
                    {
                        Console.WriteLine("Por favor ingresa un numero positivo!");
                    }
                    else
                    {
                        double metros = numero / 100;
                        Console.WriteLine($"{numero} centimetros  = {metros} metros");
                    }
                }
                if ("3".Equals(line))
                {
                    Console.Write("Ingresa la cantidad de metros : ");
                    String input = Console.ReadLine();
                    double numero = leerNumero(input);
                    if (numero < 0)
                    {
                        Console.Write("Por favor ingresa un numero positivo!");
                    }
                    else
                    {
                        double kilometros = numero / 1000;
                        Console.WriteLine($"{numero} metros  = {kilometros} kilometros");
                    }
                }
                if ("4".Equals(line))
                {
                    Console.Write("Ingresa la cantidad de kilometros : ");
                    String input = Console.ReadLine();
                    double numero = leerNumero(input);
                    if (numero < 0)
                    {
                        Console.WriteLine("Por favor ingresa un numero positivo!");
                    }
                    else
                    {
                        double metros = numero * 1000;
                        Console.WriteLine($"{numero} kilometros  = {metros} metros");
                    }
                }
                if ("0".Equals(line))
                {
                    break;
                }
            }
            Console.WriteLine("Adios!.");
        }
    }
}
