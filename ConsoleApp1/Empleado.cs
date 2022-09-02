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
        DateTime fecha_nacimiento;
        DateTime fecha_ingreso;
        float sueldo;
        static double descuento = 0.15;

        public Empleado(string nombre, string apellido, long dNI, long telefono, string direccion, DateTime fecha_nacimiento, DateTime fecha_ingreso, float sueldo) {
            this.nombre = nombre;
            this.apellido = apellido;
            DNI = dNI;
            this.telefono = telefono;
            this.direccion = direccion;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_ingreso = fecha_ingreso;
            this.sueldo = sueldo;
        }

        public int GetAntiguedadEnDias() {
            TimeSpan spanAntiguedad = DiasEntreFechas(DateTime.Now, fecha_ingreso);
            int antiguedadEnDias = (int)spanAntiguedad.TotalDays;
            return antiguedadEnDias;
        }

        public int GetEdad() {
            TimeSpan spanEdad = DiasEntreFechas(DateTime.Now, fecha_nacimiento);
            return (int)spanEdad.TotalDays / 365; // Puede fallar pero es muy baja la probabilidad. 
                                                  // Segun algo que vi en internet, quizás era mejor tratar este problema con DateTime en lugar de TimeSpan.
        }

        public double CalcularSalario() {
            double Adicional = sueldo * CalcularAdicional(); // Saco el total adicional multiplicando % por el sueldo
            double Descuento = sueldo * descuento; // Saco el descuento multiplicando el sueldo por 0.15
            double salarioFinal = sueldo + Adicional - Descuento;
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
