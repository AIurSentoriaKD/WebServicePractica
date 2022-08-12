Public Class Form1
    Dim Service As New ServiceReference1.WebService1SoapClient
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click

        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Result = Service.Suma(Nro1, Nro2)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnFactorial_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Result = Service.Fact(Nro1)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Result = Service.Resta(Nro1, Nro2)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Result = Service.Multiplicacion(Nro1, Nro2)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Result = Service.Division(Nro1, Nro2)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnRaiz_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        Dim Nro1, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Result = Service.Raiz(Nro1)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim Nro1, Nro2, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Nro2 = Double.Parse(txtNro2.Text)
        Result = Service.Potencia(Nro1, Nro2)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnSeno_Click(sender As Object, e As EventArgs) Handles btnSeno.Click
        Dim Nro1, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Result = Service.Seno(Nro1)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnCoseno_Click(sender As Object, e As EventArgs) Handles btnCoseno.Click
        Dim Nro1, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Result = Service.Coseno(Nro1)
        txtResultado.Text = Result.ToString()
    End Sub

    Private Sub btnTangente_Click(sender As Object, e As EventArgs) Handles btnTangente.Click
        Dim Nro1, Result As Double
        Nro1 = Double.Parse(txtNro1.Text)
        Result = Service.Tangente(Nro1)
        txtResultado.Text = Result.ToString()
    End Sub
End Class
