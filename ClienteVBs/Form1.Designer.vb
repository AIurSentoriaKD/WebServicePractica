<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnSeno = New System.Windows.Forms.Button()
        Me.btnCoseno = New System.Windows.Forms.Button()
        Me.btnTangente = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(97, 25)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(100, 20)
        Me.txtNro1.TabIndex = 0
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(97, 69)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(100, 20)
        Me.txtNro2.TabIndex = 1
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(45, 130)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(75, 23)
        Me.btnSumar.TabIndex = 2
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(180, 246)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(75, 23)
        Me.btnFactorial.TabIndex = 3
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(97, 296)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 4
        '
        'btnResta
        '
        Me.btnResta.Location = New System.Drawing.Point(45, 159)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(75, 23)
        Me.btnResta.TabIndex = 5
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnMult
        '
        Me.btnMult.Location = New System.Drawing.Point(45, 188)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(75, 23)
        Me.btnMult.TabIndex = 6
        Me.btnMult.Text = "Mutiplicación"
        Me.btnMult.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Location = New System.Drawing.Point(45, 217)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(75, 23)
        Me.btnDiv.TabIndex = 7
        Me.btnDiv.Text = "Division"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'btnRaiz
        '
        Me.btnRaiz.Location = New System.Drawing.Point(45, 246)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(75, 23)
        Me.btnRaiz.TabIndex = 8
        Me.btnRaiz.Text = "Raiz"
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'btnSeno
        '
        Me.btnSeno.Location = New System.Drawing.Point(180, 158)
        Me.btnSeno.Name = "btnSeno"
        Me.btnSeno.Size = New System.Drawing.Size(75, 23)
        Me.btnSeno.TabIndex = 9
        Me.btnSeno.Text = "Seno"
        Me.btnSeno.UseVisualStyleBackColor = True
        '
        'btnCoseno
        '
        Me.btnCoseno.Location = New System.Drawing.Point(180, 188)
        Me.btnCoseno.Name = "btnCoseno"
        Me.btnCoseno.Size = New System.Drawing.Size(75, 23)
        Me.btnCoseno.TabIndex = 10
        Me.btnCoseno.Text = "Coseno"
        Me.btnCoseno.UseVisualStyleBackColor = True
        '
        'btnTangente
        '
        Me.btnTangente.Location = New System.Drawing.Point(180, 217)
        Me.btnTangente.Name = "btnTangente"
        Me.btnTangente.Size = New System.Drawing.Size(75, 23)
        Me.btnTangente.TabIndex = 11
        Me.btnTangente.Text = "Tangente"
        Me.btnTangente.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(180, 130)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(75, 23)
        Me.btnPotencia.TabIndex = 12
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(301, 355)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnTangente)
        Me.Controls.Add(Me.btnCoseno)
        Me.Controls.Add(Me.btnSeno)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnSumar)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents btnSumar As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnResta As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnSeno As Button
    Friend WithEvents btnCoseno As Button
    Friend WithEvents btnTangente As Button
    Friend WithEvents btnPotencia As Button
End Class
