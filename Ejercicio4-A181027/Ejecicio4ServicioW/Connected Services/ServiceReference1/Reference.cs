//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejecicio4ServicioW.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ACuadrado", ReplyAction="*")]
        decimal ACuadrado(decimal n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ACuadrado", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> ACuadradoAsync(decimal n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ATriangulo", ReplyAction="*")]
        decimal ATriangulo(decimal n1, decimal n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ATriangulo", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> ATrianguloAsync(decimal n1, decimal n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Acirculo", ReplyAction="*")]
        decimal Acirculo(decimal n1, decimal n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Acirculo", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> AcirculoAsync(decimal n1, decimal n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Ejecicio4ServicioW.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Ejecicio4ServicioW.ServiceReference1.WebService1Soap>, Ejecicio4ServicioW.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public decimal ACuadrado(decimal n1) {
            return base.Channel.ACuadrado(n1);
        }
        
        public System.Threading.Tasks.Task<decimal> ACuadradoAsync(decimal n1) {
            return base.Channel.ACuadradoAsync(n1);
        }
        
        public decimal ATriangulo(decimal n1, decimal n2) {
            return base.Channel.ATriangulo(n1, n2);
        }
        
        public System.Threading.Tasks.Task<decimal> ATrianguloAsync(decimal n1, decimal n2) {
            return base.Channel.ATrianguloAsync(n1, n2);
        }
        
        public decimal Acirculo(decimal n1, decimal n2) {
            return base.Channel.Acirculo(n1, n2);
        }
        
        public System.Threading.Tasks.Task<decimal> AcirculoAsync(decimal n1, decimal n2) {
            return base.Channel.AcirculoAsync(n1, n2);
        }
    }
}
