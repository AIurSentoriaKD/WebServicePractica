'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference3
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference3.WebService1Soap")>  _
    Public Interface WebService1Soap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function Suma(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Suma", ReplyAction:="*")>  _
        Function SumaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function Resta(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Resta", ReplyAction:="*")>  _
        Function RestaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function Multiplicacion(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Multiplicacion", ReplyAction:="*")>  _
        Function MultiplicacionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function Division(ByVal n1 As Double, ByVal n2 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Division", ReplyAction:="*")>  _
        Function DivisionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function Raiz(ByVal n1 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Raiz", ReplyAction:="*")>  _
        Function RaizAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double)
        
        'CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento n2 del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function Potencia(ByVal request As ServiceReference3.PotenciaRequest) As ServiceReference3.PotenciaResponse
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Potencia", ReplyAction:="*")>  _
        Function PotenciaAsync(ByVal request As ServiceReference3.PotenciaRequest) As System.Threading.Tasks.Task(Of ServiceReference3.PotenciaResponse)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function Seno(ByVal n1 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Seno", ReplyAction:="*")>  _
        Function SenoAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function Coseno(ByVal n1 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Coseno", ReplyAction:="*")>  _
        Function CosenoAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function Tangente(ByVal n1 As Double) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Tangente", ReplyAction:="*")>  _
        Function TangenteAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Fact", ReplyAction:="*")>  _
        Function Fact(ByVal n As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Fact", ReplyAction:="*")>  _
        Function FactAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class PotenciaRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="Potencia", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference3.PotenciaRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference3.PotenciaRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class PotenciaRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public n1 As Double
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public n2 As String
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal n1 As Double, ByVal n2 As String)
            MyBase.New
            Me.n1 = n1
            Me.n2 = n2
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class PotenciaResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="PotenciaResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As ServiceReference3.PotenciaResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As ServiceReference3.PotenciaResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class PotenciaResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public PotenciaResult As Double
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal PotenciaResult As Double)
            MyBase.New
            Me.PotenciaResult = PotenciaResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface WebService1SoapChannel
        Inherits ServiceReference3.WebService1Soap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class WebService1SoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference3.WebService1Soap)
        Implements ServiceReference3.WebService1Soap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function Suma(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference3.WebService1Soap.Suma
            Return MyBase.Channel.Suma(n1, n2)
        End Function
        
        Public Function SumaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.SumaAsync
            Return MyBase.Channel.SumaAsync(n1, n2)
        End Function
        
        Public Function Resta(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference3.WebService1Soap.Resta
            Return MyBase.Channel.Resta(n1, n2)
        End Function
        
        Public Function RestaAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.RestaAsync
            Return MyBase.Channel.RestaAsync(n1, n2)
        End Function
        
        Public Function Multiplicacion(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference3.WebService1Soap.Multiplicacion
            Return MyBase.Channel.Multiplicacion(n1, n2)
        End Function
        
        Public Function MultiplicacionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.MultiplicacionAsync
            Return MyBase.Channel.MultiplicacionAsync(n1, n2)
        End Function
        
        Public Function Division(ByVal n1 As Double, ByVal n2 As Double) As Double Implements ServiceReference3.WebService1Soap.Division
            Return MyBase.Channel.Division(n1, n2)
        End Function
        
        Public Function DivisionAsync(ByVal n1 As Double, ByVal n2 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.DivisionAsync
            Return MyBase.Channel.DivisionAsync(n1, n2)
        End Function
        
        Public Function Raiz(ByVal n1 As Double) As Double Implements ServiceReference3.WebService1Soap.Raiz
            Return MyBase.Channel.Raiz(n1)
        End Function
        
        Public Function RaizAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.RaizAsync
            Return MyBase.Channel.RaizAsync(n1)
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference3_WebService1Soap_Potencia(ByVal request As ServiceReference3.PotenciaRequest) As ServiceReference3.PotenciaResponse Implements ServiceReference3.WebService1Soap.Potencia
            Return MyBase.Channel.Potencia(request)
        End Function
        
        Public Function Potencia(ByVal n1 As Double, ByVal n2 As String) As Double
            Dim inValue As ServiceReference3.PotenciaRequest = New ServiceReference3.PotenciaRequest()
            inValue.Body = New ServiceReference3.PotenciaRequestBody()
            inValue.Body.n1 = n1
            inValue.Body.n2 = n2
            Dim retVal As ServiceReference3.PotenciaResponse = CType(Me,ServiceReference3.WebService1Soap).Potencia(inValue)
            Return retVal.Body.PotenciaResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function ServiceReference3_WebService1Soap_PotenciaAsync(ByVal request As ServiceReference3.PotenciaRequest) As System.Threading.Tasks.Task(Of ServiceReference3.PotenciaResponse) Implements ServiceReference3.WebService1Soap.PotenciaAsync
            Return MyBase.Channel.PotenciaAsync(request)
        End Function
        
        Public Function PotenciaAsync(ByVal n1 As Double, ByVal n2 As String) As System.Threading.Tasks.Task(Of ServiceReference3.PotenciaResponse)
            Dim inValue As ServiceReference3.PotenciaRequest = New ServiceReference3.PotenciaRequest()
            inValue.Body = New ServiceReference3.PotenciaRequestBody()
            inValue.Body.n1 = n1
            inValue.Body.n2 = n2
            Return CType(Me,ServiceReference3.WebService1Soap).PotenciaAsync(inValue)
        End Function
        
        Public Function Seno(ByVal n1 As Double) As Double Implements ServiceReference3.WebService1Soap.Seno
            Return MyBase.Channel.Seno(n1)
        End Function
        
        Public Function SenoAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.SenoAsync
            Return MyBase.Channel.SenoAsync(n1)
        End Function
        
        Public Function Coseno(ByVal n1 As Double) As Double Implements ServiceReference3.WebService1Soap.Coseno
            Return MyBase.Channel.Coseno(n1)
        End Function
        
        Public Function CosenoAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.CosenoAsync
            Return MyBase.Channel.CosenoAsync(n1)
        End Function
        
        Public Function Tangente(ByVal n1 As Double) As Double Implements ServiceReference3.WebService1Soap.Tangente
            Return MyBase.Channel.Tangente(n1)
        End Function
        
        Public Function TangenteAsync(ByVal n1 As Double) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.TangenteAsync
            Return MyBase.Channel.TangenteAsync(n1)
        End Function
        
        Public Function Fact(ByVal n As Integer) As Double Implements ServiceReference3.WebService1Soap.Fact
            Return MyBase.Channel.Fact(n)
        End Function
        
        Public Function FactAsync(ByVal n As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference3.WebService1Soap.FactAsync
            Return MyBase.Channel.FactAsync(n)
        End Function
    End Class
End Namespace
