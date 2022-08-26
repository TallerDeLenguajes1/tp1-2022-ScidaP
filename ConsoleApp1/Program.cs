using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using static ConsoleApp1.Provincias;

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
            // PROBLEMA 3
            try {
                Console.WriteLine("Ingrese los km recorridos");
                int kmRecorridos= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese los litros usados");
                int ltUsados = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resultado: " + CalcularDivision(kmRecorridos, ltUsados));
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
            // PROBLEMA 4
            var url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            try {
                WebResponse response = request.GetResponse();
                Stream strReader = response.GetResponseStream();
                StreamReader ObjReader = new StreamReader(strReader);
                string datos = ObjReader.ReadToEnd();
                Root listProvincias = JsonSerializer.Deserialize<Root>(datos);
                int i = 1;
                foreach (Provincia datosProvincias in listProvincias.provincias) {
                    Console.WriteLine("Nombre provincia N°" + i + ": " + datosProvincias.nombre);
                    i++;
                }
                Console.WriteLine("hola");
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
