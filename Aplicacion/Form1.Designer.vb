<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxResultado = New System.Windows.Forms.TextBox()
        Me.lbl_Estandard = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.ButtonSumar = New System.Windows.Forms.Button()
        Me.ButtonIgual = New System.Windows.Forms.Button()
        Me.ButtonRestar = New System.Windows.Forms.Button()
        Me.ButtonMultiplicar = New System.Windows.Forms.Button()
        Me.ButtonDividir = New System.Windows.Forms.Button()
        Me.ButtonBorrar1 = New System.Windows.Forms.Button()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonCE = New System.Windows.Forms.Button()
        Me.ButtonComa = New System.Windows.Forms.Button()
        Me.ButtonCambioSigno = New System.Windows.Forms.Button()
        Me.LabelValorAnterior = New System.Windows.Forms.Label()
        Me.TextBoxValorAnterior = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(22, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBoxResultado
        '
        Me.TextBoxResultado.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TextBoxResultado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResultado.ForeColor = System.Drawing.SystemColors.Menu
        Me.TextBoxResultado.Location = New System.Drawing.Point(22, 84)
        Me.TextBoxResultado.Name = "TextBoxResultado"
        Me.TextBoxResultado.ReadOnly = True
        Me.TextBoxResultado.Size = New System.Drawing.Size(321, 37)
        Me.TextBoxResultado.TabIndex = 1
        Me.TextBoxResultado.TabStop = False
        Me.TextBoxResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Estandard
        '
        Me.lbl_Estandard.AutoSize = True
        Me.lbl_Estandard.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Estandard.Location = New System.Drawing.Point(17, 9)
        Me.lbl_Estandard.Name = "lbl_Estandard"
        Me.lbl_Estandard.Size = New System.Drawing.Size(95, 24)
        Me.lbl_Estandard.TabIndex = 2
        Me.lbl_Estandard.Text = "Estándard"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(104, 309)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 50)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(186, 309)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 50)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(22, 252)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 51)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(104, 252)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 51)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(186, 252)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 51)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "6"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(22, 194)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 52)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "7"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(104, 194)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 52)
        Me.Button8.TabIndex = 9
        Me.Button8.Text = "8"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(186, 194)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 52)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button0
        '
        Me.Button0.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button0.ForeColor = System.Drawing.Color.White
        Me.Button0.Location = New System.Drawing.Point(104, 365)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(75, 53)
        Me.Button0.TabIndex = 11
        Me.Button0.Text = "0"
        Me.Button0.UseVisualStyleBackColor = False
        '
        'ButtonSumar
        '
        Me.ButtonSumar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonSumar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSumar.ForeColor = System.Drawing.Color.White
        Me.ButtonSumar.Location = New System.Drawing.Point(268, 309)
        Me.ButtonSumar.Name = "ButtonSumar"
        Me.ButtonSumar.Size = New System.Drawing.Size(75, 50)
        Me.ButtonSumar.TabIndex = 12
        Me.ButtonSumar.Text = "+"
        Me.ButtonSumar.UseVisualStyleBackColor = False
        '
        'ButtonIgual
        '
        Me.ButtonIgual.BackColor = System.Drawing.Color.DodgerBlue
        Me.ButtonIgual.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonIgual.ForeColor = System.Drawing.Color.Black
        Me.ButtonIgual.Location = New System.Drawing.Point(268, 368)
        Me.ButtonIgual.Name = "ButtonIgual"
        Me.ButtonIgual.Size = New System.Drawing.Size(75, 50)
        Me.ButtonIgual.TabIndex = 13
        Me.ButtonIgual.Text = "="
        Me.ButtonIgual.UseVisualStyleBackColor = False
        '
        'ButtonRestar
        '
        Me.ButtonRestar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonRestar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRestar.ForeColor = System.Drawing.Color.White
        Me.ButtonRestar.Location = New System.Drawing.Point(267, 253)
        Me.ButtonRestar.Name = "ButtonRestar"
        Me.ButtonRestar.Size = New System.Drawing.Size(75, 50)
        Me.ButtonRestar.TabIndex = 14
        Me.ButtonRestar.Text = "-"
        Me.ButtonRestar.UseVisualStyleBackColor = False
        '
        'ButtonMultiplicar
        '
        Me.ButtonMultiplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonMultiplicar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMultiplicar.ForeColor = System.Drawing.Color.White
        Me.ButtonMultiplicar.Location = New System.Drawing.Point(268, 194)
        Me.ButtonMultiplicar.Name = "ButtonMultiplicar"
        Me.ButtonMultiplicar.Size = New System.Drawing.Size(75, 53)
        Me.ButtonMultiplicar.TabIndex = 15
        Me.ButtonMultiplicar.Text = "X"
        Me.ButtonMultiplicar.UseVisualStyleBackColor = False
        '
        'ButtonDividir
        '
        Me.ButtonDividir.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonDividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDividir.ForeColor = System.Drawing.Color.White
        Me.ButtonDividir.Location = New System.Drawing.Point(267, 135)
        Me.ButtonDividir.Name = "ButtonDividir"
        Me.ButtonDividir.Size = New System.Drawing.Size(75, 53)
        Me.ButtonDividir.TabIndex = 16
        Me.ButtonDividir.Text = "/"
        Me.ButtonDividir.UseVisualStyleBackColor = False
        '
        'ButtonBorrar1
        '
        Me.ButtonBorrar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonBorrar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBorrar1.ForeColor = System.Drawing.Color.White
        Me.ButtonBorrar1.Location = New System.Drawing.Point(185, 135)
        Me.ButtonBorrar1.Name = "ButtonBorrar1"
        Me.ButtonBorrar1.Size = New System.Drawing.Size(75, 53)
        Me.ButtonBorrar1.TabIndex = 17
        Me.ButtonBorrar1.Text = "<-"
        Me.ButtonBorrar1.UseVisualStyleBackColor = False
        '
        'ButtonC
        '
        Me.ButtonC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonC.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonC.ForeColor = System.Drawing.Color.White
        Me.ButtonC.Location = New System.Drawing.Point(104, 135)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(75, 53)
        Me.ButtonC.TabIndex = 18
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = False
        '
        'ButtonCE
        '
        Me.ButtonCE.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCE.ForeColor = System.Drawing.Color.White
        Me.ButtonCE.Location = New System.Drawing.Point(23, 135)
        Me.ButtonCE.Name = "ButtonCE"
        Me.ButtonCE.Size = New System.Drawing.Size(75, 53)
        Me.ButtonCE.TabIndex = 19
        Me.ButtonCE.Text = "CE"
        Me.ButtonCE.UseVisualStyleBackColor = False
        '
        'ButtonComa
        '
        Me.ButtonComa.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonComa.ForeColor = System.Drawing.Color.White
        Me.ButtonComa.Location = New System.Drawing.Point(187, 365)
        Me.ButtonComa.Name = "ButtonComa"
        Me.ButtonComa.Size = New System.Drawing.Size(75, 53)
        Me.ButtonComa.TabIndex = 20
        Me.ButtonComa.Text = ","
        Me.ButtonComa.UseVisualStyleBackColor = False
        '
        'ButtonCambioSigno
        '
        Me.ButtonCambioSigno.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonCambioSigno.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCambioSigno.ForeColor = System.Drawing.Color.White
        Me.ButtonCambioSigno.Location = New System.Drawing.Point(23, 365)
        Me.ButtonCambioSigno.Name = "ButtonCambioSigno"
        Me.ButtonCambioSigno.Size = New System.Drawing.Size(75, 53)
        Me.ButtonCambioSigno.TabIndex = 21
        Me.ButtonCambioSigno.Text = "+/-"
        Me.ButtonCambioSigno.UseVisualStyleBackColor = False
        '
        'LabelValorAnterior
        '
        Me.LabelValorAnterior.AutoSize = True
        Me.LabelValorAnterior.Location = New System.Drawing.Point(302, 56)
        Me.LabelValorAnterior.Name = "LabelValorAnterior"
        Me.LabelValorAnterior.Size = New System.Drawing.Size(0, 13)
        Me.LabelValorAnterior.TabIndex = 22
        '
        'TextBoxValorAnterior
        '
        Me.TextBoxValorAnterior.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.TextBoxValorAnterior.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxValorAnterior.Enabled = False
        Me.TextBoxValorAnterior.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TextBoxValorAnterior.Location = New System.Drawing.Point(23, 49)
        Me.TextBoxValorAnterior.Name = "TextBoxValorAnterior"
        Me.TextBoxValorAnterior.ReadOnly = True
        Me.TextBoxValorAnterior.Size = New System.Drawing.Size(319, 13)
        Me.TextBoxValorAnterior.TabIndex = 23
        Me.TextBoxValorAnterior.TabStop = False
        Me.TextBoxValorAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Calculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(366, 437)
        Me.Controls.Add(Me.TextBoxValorAnterior)
        Me.Controls.Add(Me.LabelValorAnterior)
        Me.Controls.Add(Me.ButtonCambioSigno)
        Me.Controls.Add(Me.ButtonComa)
        Me.Controls.Add(Me.ButtonCE)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonBorrar1)
        Me.Controls.Add(Me.ButtonDividir)
        Me.Controls.Add(Me.ButtonMultiplicar)
        Me.Controls.Add(Me.ButtonRestar)
        Me.Controls.Add(Me.ButtonIgual)
        Me.Controls.Add(Me.ButtonSumar)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lbl_Estandard)
        Me.Controls.Add(Me.TextBoxResultado)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Calculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxResultado As TextBox
    Friend WithEvents lbl_Estandard As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents ButtonSumar As Button
    Friend WithEvents ButtonIgual As Button
    Friend WithEvents ButtonRestar As Button
    Friend WithEvents ButtonMultiplicar As Button
    Friend WithEvents ButtonDividir As Button
    Friend WithEvents ButtonBorrar1 As Button
    Friend WithEvents ButtonC As Button
    Friend WithEvents ButtonCE As Button
    Friend WithEvents ButtonComa As Button
    Friend WithEvents ButtonCambioSigno As Button
    Friend WithEvents LabelValorAnterior As Label
    Friend WithEvents TextBoxValorAnterior As TextBox
End Class
