<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceTest.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title>Cliente Web</title>
</head>

<body>
    <div class="container align-items-center justify-content-center text-center">
            <form id="form1" runat="server">
        <div>
            <br />
            Num1 <asp:TextBox ID="txtnum1" runat="server">

            </asp:TextBox>
            <br />
            <br />
            Num2 <asp:TextBox ID="txtnum2" runat="server">

            </asp:TextBox>
            <br />
            <br />
            <div class="col-lg-">
                <asp:Button ID="Button1" runat="server" Text="Suma" OnClick="btnSumar" />
                <asp:Button ID="Button2" runat="server" Text="Resta" OnClick="btnResta" />
                <asp:Button ID="Button3" runat="server" Text="Multiplicación" OnClick="btnMultipl" />
                <asp:Button ID="Button4" runat="server" Text="Division" OnClick="btnDiv" />
                <asp:Button ID="Button5" runat="server" Text="Potencia" OnClick="ptnPoten" />
            </div>
            <div>
                <asp:Button ID="Button6" runat="server" Text="Raiz" OnClick="btnRaiz" />
                <asp:Button ID="Button7" runat="server" Text="Seno" OnClick="btnSeno" />
                <asp:Button ID="Button8" runat="server" Text="Coseno" OnClick="btnCoseno" />
                <asp:Button ID="Button9" runat="server" Text="Tangente" OnClick="btnTangente" />
                <asp:Button ID="Button10" runat="server" Text="Factorial" OnClick="btnFactorial" />
            </div>
           
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Respuesta: ">

            </asp:Label>
            <asp:Label ID="Label1" runat="server" Text=" ">

            </asp:Label>
        </div>
    </form>
    </div>
</body>
</html>
