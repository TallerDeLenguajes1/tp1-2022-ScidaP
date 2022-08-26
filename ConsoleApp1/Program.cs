using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            /////////// PUNTO 2)
            // PROBLEMA 1
            try {
                Console.WriteLine("Ingrese un número para encontrar su cuadrado:");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + CalcularCuadrado(numeroIngresado));
            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
            // PROBLEMA 2
            try {
                Console.WriteLine("Ingrese el dividendo");
                int primerNumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor");
                int segundoNumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + CalcularDivision(primerNumero, segundoNumero));
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static int CalcularCuadrado(int a) {
            return a * a;
        }

        public static float CalcularDivision(int a, int b) {
            return a / b;
        }
    }
}
