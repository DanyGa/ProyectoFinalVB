<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaDobleCircular
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblLista = New System.Windows.Forms.Label()
        Me.lblThis = New System.Windows.Forms.Label()
        Me.lblDato = New System.Windows.Forms.Label()
        Me.txtNodo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Snow
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Button1.Location = New System.Drawing.Point(56, 89)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 58)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.YellowGreen
        Me.Button2.Location = New System.Drawing.Point(56, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(129, 58)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Snow
        Me.Button3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.YellowGreen
        Me.Button3.Location = New System.Drawing.Point(56, 279)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 58)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnContar
        '
        Me.btnContar.BackColor = System.Drawing.Color.Snow
        Me.btnContar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnContar.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnContar.Location = New System.Drawing.Point(459, 89)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(129, 58)
        Me.btnContar.TabIndex = 3
        Me.btnContar.Text = "Button4"
        Me.btnContar.UseVisualStyleBackColor = False
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.Color.Snow
        Me.btnCargar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCargar.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnCargar.Location = New System.Drawing.Point(640, 300)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(129, 58)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar Lista"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Snow
        Me.btnMenu.Font = New System.Drawing.Font("Modern No. 20", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnMenu.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnMenu.Location = New System.Drawing.Point(766, 405)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(90, 43)
        Me.btnMenu.TabIndex = 6
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 22.2!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblTitulo.Location = New System.Drawing.Point(226, 39)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(414, 49)
        Me.lblTitulo.TabIndex = 7
        Me.lblTitulo.Text = "Lista Doble Circular"
        '
        'lblLista
        '
        Me.lblLista.AutoSize = True
        Me.lblLista.BackColor = System.Drawing.Color.Snow
        Me.lblLista.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblLista.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblLista.Location = New System.Drawing.Point(358, 153)
        Me.lblLista.Name = "lblLista"
        Me.lblLista.Size = New System.Drawing.Size(42, 31)
        Me.lblLista.TabIndex = 8
        Me.lblLista.Text = "----"
        '
        'lblThis
        '
        Me.lblThis.AutoSize = True
        Me.lblThis.BackColor = System.Drawing.Color.Snow
        Me.lblThis.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblThis.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblThis.Location = New System.Drawing.Point(253, 153)
        Me.lblThis.Name = "lblThis"
        Me.lblThis.Size = New System.Drawing.Size(81, 31)
        Me.lblThis.TabIndex = 9
        Me.lblThis.Text = "Lista:"
        '
        'lblDato
        '
        Me.lblDato.AutoSize = True
        Me.lblDato.BackColor = System.Drawing.Color.Snow
        Me.lblDato.Font = New System.Drawing.Font("Britannic Bold", 16.2!)
        Me.lblDato.ForeColor = System.Drawing.Color.YellowGreen
        Me.lblDato.Location = New System.Drawing.Point(253, 271)
        Me.lblDato.Name = "lblDato"
        Me.lblDato.Size = New System.Drawing.Size(79, 31)
        Me.lblDato.TabIndex = 10
        Me.lblDato.Text = "Dato:"
        '
        'txtNodo
        '
        Me.txtNodo.BackColor = System.Drawing.Color.Snow
        Me.txtNodo.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        Me.txtNodo.ForeColor = System.Drawing.Color.YellowGreen
        Me.txtNodo.Location = New System.Drawing.Point(364, 277)
        Me.txtNodo.Name = "txtNodo"
        Me.txtNodo.Size = New System.Drawing.Size(134, 26)
        Me.txtNodo.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Snow
        Me.btnGuardar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.YellowGreen
        Me.btnGuardar.Location = New System.Drawing.Point(640, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(129, 58)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Guardar Lista"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'ListaDobleCircular
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.ListaDobleCircular
        Me.ClientSize = New System.Drawing.Size(951, 481)
        Me.Controls.Add(Me.txtNodo)
        Me.Controls.Add(Me.lblDato)
        Me.Controls.Add(Me.lblThis)
        Me.Controls.Add(Me.lblLista)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "ListaDobleCircular"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Doble Circular"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnContar As Button
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnMenu As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblLista As Label
    Friend WithEvents lblThis As Label
    Friend WithEvents lblDato As Label
    Friend WithEvents txtNodo As TextBox
    Friend WithEvents btnGuardar As Button
End Class
