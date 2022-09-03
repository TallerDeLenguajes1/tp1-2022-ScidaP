using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Empleado {
        string nombre;
        string apellido;
        long DNI;
        long telefono;
        string direccion;
        bool casado;
        int cant_hijos;
        bool divorciado;
        DateTime fecha_divorcio;
        bool titulo_universitario;
        string nombre_titulo_universitario;
        string universidad;
        DateTime fecha_nacimiento;
        DateTime fecha_ingreso;
        float sueldo;
        static double descuento = 0.15;

        public Empleado(string nombre, string apellido, long dNI1, long telefono, string direccion, bool casado, int cant_hijos, bool divorciado, DateTime fecha_divorcio, bool titulo_universitario, string nombre_titulo_universitario, string universidad, DateTime fecha_nacimiento, DateTime fecha_ingreso, float sueldo) {
            Nombre = nombre;
            Apellido = apellido;
            DNI1 = dNI1;
            Telefono = telefono;
            Direccion = direccion;
            Casado = casado;
            Cant_hijos = cant_hijos;
            Divorciado = divorciado;
            Fecha_divorcio = fecha_divorcio;
            Titulo_universitario = titulo_universitario;
            Nombre_titulo_universitario = nombre_titulo_universitario;
            Universidad = universidad;
            Fecha_nacimiento = fecha_nacimiento;
            Fecha_ingreso = fecha_ingreso;
            Sueldo = sueldo;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public long DNI1 { get => DNI; set => DNI = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public bool Casado { get => casado; set => casado = value; }
        public int Cant_hijos { get => cant_hijos; set => cant_hijos = value; }
        public bool Divorciado { get => divorciado; set => divorciado = value; }
        public DateTime Fecha_divorcio { get => fecha_divorcio; set => fecha_divorcio = value; }
        public bool Titulo_universitario { get => titulo_universitario; set => titulo_universitario = value; }
        public string Nombre_titulo_universitario { get => nombre_titulo_universitario; set => nombre_titulo_universitario = value; }
        public string Universidad { get => universidad; set => universidad = value; }
        public DateTime Fecha_nacimiento { get => fecha_nacimiento; set => fecha_nacimiento = value; }
        public DateTime Fecha_ingreso { get => fecha_ingreso; set => fecha_ingreso = value; }
        public float Sueldo { get => sueldo; set => sueldo = value; }
        public static double Descuento { get => descuento; set => descuento = value; }

        public int GetAntiguedadEnDias() {
            TimeSpan spanAntiguedad = DiasEntreFechas(DateTime.Now, Fecha_ingreso);
            int antiguedadEnDias = (int)spanAntiguedad.TotalDays;
            return antiguedadEnDias;
        }

        public int GetEdad() {
            TimeSpan spanEdad = DiasEntreFechas(DateTime.Now, Fecha_nacimiento);
            return (int)spanEdad.TotalDays / 365; // Puede fallar pero es muy baja la probabilidad. 
                                                  // Segun algo que vi en internet, quizás era mejor tratar este problema con DateTime en lugar de TimeSpan.
        }

        public double CalcularSalario() {
            double Adicional = Sueldo * CalcularAdicional(); // Saco el total adicional multiplicando % por el sueldo
            double Descuento = Sueldo * Empleado.Descuento; // Saco el descuento multiplicando el sueldo por 0.15
            double salarioFinal = Sueldo + Adicional - Descuento;
            return salarioFinal;
        }

        double CalcularAdicional() {
            int AniosAntiguedad = GetAntiguedadEnDias() / 365;
            if (AniosAntiguedad < 20) {
                return AniosAntiguedad * 0.01;
            } else {
                return 0.25;
            }
        }

        static TimeSpan DiasEntreFechas(DateTime fecha1, DateTime fecha2) {
            TimeSpan timespan = fecha2.Subtract(fecha1);
            return timespan;
        }
    }
}
