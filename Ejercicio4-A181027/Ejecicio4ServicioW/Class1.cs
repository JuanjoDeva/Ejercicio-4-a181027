using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejecicio4ServicioW
{
    public class Class1
    {
        public decimal dato1 { get; set; }
        public decimal dato2 { get; set; }

        public decimal Acuadrado()
        {
            return dato1 * dato1;
        }

        public decimal Atriangulo()
        { 
            return dato1 * dato2 / 2;
        }

        public decimal Acirculo()
        {
            var pi = Convert.ToDecimal(3.1416);
            var radio = dato1*dato1;
            var resultado = pi * radio;
            return Convert.ToDecimal(resultado);
        }
    }
}