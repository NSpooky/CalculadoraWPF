using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraWPF
{
    class Operadores
    {
        double resultado;

        public double Suma(double a, double b)
        {
            resultado = a + b;
            return resultado;
        }

        public double Resta(double a, double b)
        {
            resultado = a - b;
            return resultado;
        }
        public double Multiplicacion(double a, double b)
        {
            resultado = a * b;
            return resultado;
        }
        public double Division(double a, double b)
        {
                resultado = a / b;
                return resultado;
        }
    }
}
