//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceTest.WSOnline {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WSOnline.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        double Suma(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Suma", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SumaAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        double Resta(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Resta", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RestaAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicacion", ReplyAction="*")]
        double Multiplicacion(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplicacion", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MultiplicacionAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        double Division(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Division", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DivisionAsync(double n1, double n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Raiz", ReplyAction="*")]
        double Raiz(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Raiz", ReplyAction="*")]
        System.Threading.Tasks.Task<double> RaizAsync(double n1);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento n2 del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Potencia", ReplyAction="*")]
        WebServiceTest.WSOnline.PotenciaResponse Potencia(WebServiceTest.WSOnline.PotenciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Potencia", ReplyAction="*")]
        System.Threading.Tasks.Task<WebServiceTest.WSOnline.PotenciaResponse> PotenciaAsync(WebServiceTest.WSOnline.PotenciaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seno", ReplyAction="*")]
        double Seno(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Seno", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SenoAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Coseno", ReplyAction="*")]
        double Coseno(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Coseno", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CosenoAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tangente", ReplyAction="*")]
        double Tangente(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Tangente", ReplyAction="*")]
        System.Threading.Tasks.Task<double> TangenteAsync(double n1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fact", ReplyAction="*")]
        double Fact(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Fact", ReplyAction="*")]
        System.Threading.Tasks.Task<double> FactAsync(int n);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PotenciaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Potencia", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.WSOnline.PotenciaRequestBody Body;
        
        public PotenciaRequest() {
        }
        
        public PotenciaRequest(WebServiceTest.WSOnline.PotenciaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PotenciaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double n1;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string n2;
        
        public PotenciaRequestBody() {
        }
        
        public PotenciaRequestBody(double n1, string n2) {
            this.n1 = n1;
            this.n2 = n2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PotenciaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PotenciaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTest.WSOnline.PotenciaResponseBody Body;
        
        public PotenciaResponse() {
        }
        
        public PotenciaResponse(WebServiceTest.WSOnline.PotenciaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PotenciaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double PotenciaResult;
        
        public PotenciaResponseBody() {
        }
        
        public PotenciaResponseBody(double PotenciaResult) {
            this.PotenciaResult = PotenciaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebServiceTest.WSOnline.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebServiceTest.WSOnline.WebService1Soap>, WebServiceTest.WSOnline.WebService1Soap {
        
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
        
        public double Suma(double n1, double n2) {
            return base.Channel.Suma(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> SumaAsync(double n1, double n2) {
            return base.Channel.SumaAsync(n1, n2);
        }
        
        public double Resta(double n1, double n2) {
            return base.Channel.Resta(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> RestaAsync(double n1, double n2) {
            return base.Channel.RestaAsync(n1, n2);
        }
        
        public double Multiplicacion(double n1, double n2) {
            return base.Channel.Multiplicacion(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicacionAsync(double n1, double n2) {
            return base.Channel.MultiplicacionAsync(n1, n2);
        }
        
        public double Division(double n1, double n2) {
            return base.Channel.Division(n1, n2);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double n1, double n2) {
            return base.Channel.DivisionAsync(n1, n2);
        }
        
        public double Raiz(double n1) {
            return base.Channel.Raiz(n1);
        }
        
        public System.Threading.Tasks.Task<double> RaizAsync(double n1) {
            return base.Channel.RaizAsync(n1);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTest.WSOnline.PotenciaResponse WebServiceTest.WSOnline.WebService1Soap.Potencia(WebServiceTest.WSOnline.PotenciaRequest request) {
            return base.Channel.Potencia(request);
        }
        
        public double Potencia(double n1, string n2) {
            WebServiceTest.WSOnline.PotenciaRequest inValue = new WebServiceTest.WSOnline.PotenciaRequest();
            inValue.Body = new WebServiceTest.WSOnline.PotenciaRequestBody();
            inValue.Body.n1 = n1;
            inValue.Body.n2 = n2;
            WebServiceTest.WSOnline.PotenciaResponse retVal = ((WebServiceTest.WSOnline.WebService1Soap)(this)).Potencia(inValue);
            return retVal.Body.PotenciaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebServiceTest.WSOnline.PotenciaResponse> WebServiceTest.WSOnline.WebService1Soap.PotenciaAsync(WebServiceTest.WSOnline.PotenciaRequest request) {
            return base.Channel.PotenciaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebServiceTest.WSOnline.PotenciaResponse> PotenciaAsync(double n1, string n2) {
            WebServiceTest.WSOnline.PotenciaRequest inValue = new WebServiceTest.WSOnline.PotenciaRequest();
            inValue.Body = new WebServiceTest.WSOnline.PotenciaRequestBody();
            inValue.Body.n1 = n1;
            inValue.Body.n2 = n2;
            return ((WebServiceTest.WSOnline.WebService1Soap)(this)).PotenciaAsync(inValue);
        }
        
        public double Seno(double n1) {
            return base.Channel.Seno(n1);
        }
        
        public System.Threading.Tasks.Task<double> SenoAsync(double n1) {
            return base.Channel.SenoAsync(n1);
        }
        
        public double Coseno(double n1) {
            return base.Channel.Coseno(n1);
        }
        
        public System.Threading.Tasks.Task<double> CosenoAsync(double n1) {
            return base.Channel.CosenoAsync(n1);
        }
        
        public double Tangente(double n1) {
            return base.Channel.Tangente(n1);
        }
        
        public System.Threading.Tasks.Task<double> TangenteAsync(double n1) {
            return base.Channel.TangenteAsync(n1);
        }
        
        public double Fact(int n) {
            return base.Channel.Fact(n);
        }
        
        public System.Threading.Tasks.Task<double> FactAsync(int n) {
            return base.Channel.FactAsync(n);
        }
    }
}
