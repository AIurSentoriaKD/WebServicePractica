using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceTest
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        // suma
        [WebMethod(Description = "Sumar dos numeros")]
        public double Suma(double n1, double n2)
        {
            double rslt;
            rslt = n1 + n2;
            return rslt;
        }
        // resta
        [WebMethod(Description = "Resta de dos numeros")]
        public double Resta(double n1, double n2)
        {
            return n1 - n2;
        }

        // multiplicación
        [WebMethod(Description = "Multiplicación de dos numeros")]
        public double Multiplicacion(double n1, double n2)
        {
            return n1 * n2;
        }

        // division
        [WebMethod(Description = "Division de dos numeros")]
        public double Division(double n1, double n2)
        {
            if(n2 == 0)
            {
                return double.NaN;
            }
            else
            {
                return n1 / n2;
            }
        }

        // raiz
        [WebMethod(Description = "Raiz cuadrada de un numero")]
        public double Raiz(double n1)
        {
            return Math.Sqrt(n1);
        }

        // potencia
        [WebMethod(Description = "Potencia de un numero")]
        public double Potencia(double n1, String n2)
        {
            if (n2.Equals(""))
            {
                return Math.Pow(n1, 2);
            }
            else
            {
                return Math.Pow(n1, Convert.ToDouble(n2));
            }
        }   

        // seno
        [WebMethod(Description = "Seno de un numero")]
        public double Seno(double n1)
        {
            return Math.Sin(n1);
        }

        // coseno
        [WebMethod(Description = "Coseno de un numero")]
        public double Coseno(double n1)
        {
            return Math.Cos(n1);
        }

        // tangente
        [WebMethod(Description = "Tangente de un numero")]
        public double Tangente(double n1)
        {
            return Math.Tan(n1);
        }

        // factorial
        private double factorial(int n)
        {
            if (n == 0) return 1;
            else return n * factorial(n - 1);
        }

        [WebMethod(Description = "Factorial de un numero")]
        public double Fact(int n)
        {
            return factorial(n);
        }
    }
}
