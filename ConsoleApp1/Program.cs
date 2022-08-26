using System;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            // PROBLEMA 1
            try {
                Console.WriteLine("Ingrese un número para encontrar su cuadrado:");
                int numeroIngresado = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + CalcularCuadrado(numeroIngresado));
            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
        }

        public static int CalcularCuadrado(int a) {
            return a * a;
        }
    }
}
