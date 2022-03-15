using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejecicio4ServicioW
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

        [WebMethod]
        public Decimal ACuadrado(decimal n1)
        {
            Class1 SP = new Class1();
            SP.dato1 = n1;
            return SP.Acuadrado();
        }

        [WebMethod]
        public Decimal ATriangulo(decimal n1, decimal n2)
        {
            Class1 SP = new Class1();
            SP.dato1 = n1;
            SP.dato2 = n2;
            return SP.Atriangulo();
        }
        [WebMethod]
        public Decimal Acirculo(decimal n1)
        {
            Class1 SP = new Class1();
            SP.dato1 = n1;
            return SP.Acirculo();
        }
    }
}
