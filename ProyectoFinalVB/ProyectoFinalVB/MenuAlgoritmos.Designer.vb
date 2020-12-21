<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAlgoritmos
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
        Me.lblIns = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.btnBubble = New System.Windows.Forms.Button()
        Me.btnCocktail = New System.Windows.Forms.Button()
        Me.btnCounting = New System.Windows.Forms.Button()
        Me.btnRadix = New System.Windows.Forms.Button()
        Me.btnShell = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblIns
        '
        Me.lblIns.AutoSize = True
        Me.lblIns.BackColor = System.Drawing.Color.Snow
        Me.lblIns.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold)
        Me.lblIns.ForeColor = System.Drawing.Color.Crimson
        Me.lblIns.Location = New System.Drawing.Point(166, 74)
        Me.lblIns.Name = "lblIns"
        Me.lblIns.Size = New System.Drawing.Size(406, 30)
        Me.lblIns.TabIndex = 0
        Me.lblIns.Text = "Selecciona un tipo de Algoritmo"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.Color.Snow
        Me.lblTitulo.Font = New System.Drawing.Font("Elephant", 25.8!)
        Me.lblTitulo.ForeColor = System.Drawing.Color.Crimson
        Me.lblTitulo.Location = New System.Drawing.Point(38, 19)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(644, 55)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Algoritmos de Ordenamiento"
        '
        'btnBubble
        '
        Me.btnBubble.BackColor = System.Drawing.Color.Snow
        Me.btnBubble.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBubble.ForeColor = System.Drawing.Color.Crimson
        Me.btnBubble.Location = New System.Drawing.Point(56, 176)
        Me.btnBubble.Name = "btnBubble"
        Me.btnBubble.Size = New System.Drawing.Size(167, 67)
        Me.btnBubble.TabIndex = 2
        Me.btnBubble.Text = "Bubble Sort"
        Me.btnBubble.UseVisualStyleBackColor = False
        '
        'btnCocktail
        '
        Me.btnCocktail.BackColor = System.Drawing.Color.Snow
        Me.btnCocktail.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCocktail.ForeColor = System.Drawing.Color.Crimson
        Me.btnCocktail.Location = New System.Drawing.Point(294, 176)
        Me.btnCocktail.Name = "btnCocktail"
        Me.btnCocktail.Size = New System.Drawing.Size(167, 67)
        Me.btnCocktail.TabIndex = 3
        Me.btnCocktail.Text = "Cocktail Sort"
        Me.btnCocktail.UseVisualStyleBackColor = False
        '
        'btnCounting
        '
        Me.btnCounting.BackColor = System.Drawing.Color.Snow
        Me.btnCounting.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCounting.ForeColor = System.Drawing.Color.Crimson
        Me.btnCounting.Location = New System.Drawing.Point(533, 176)
        Me.btnCounting.Name = "btnCounting"
        Me.btnCounting.Size = New System.Drawing.Size(167, 67)
        Me.btnCounting.TabIndex = 5
        Me.btnCounting.Text = "Counting Sort"
        Me.btnCounting.UseVisualStyleBackColor = False
        '
        'btnRadix
        '
        Me.btnRadix.BackColor = System.Drawing.Color.Snow
        Me.btnRadix.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnRadix.ForeColor = System.Drawing.Color.Crimson
        Me.btnRadix.Location = New System.Drawing.Point(162, 314)
        Me.btnRadix.Name = "btnRadix"
        Me.btnRadix.Size = New System.Drawing.Size(167, 67)
        Me.btnRadix.TabIndex = 6
        Me.btnRadix.Text = "Radix Sort"
        Me.btnRadix.UseVisualStyleBackColor = False
        '
        'btnShell
        '
        Me.btnShell.BackColor = System.Drawing.Color.Snow
        Me.btnShell.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnShell.ForeColor = System.Drawing.Color.Crimson
        Me.btnShell.Location = New System.Drawing.Point(422, 314)
        Me.btnShell.Name = "btnShell"
        Me.btnShell.Size = New System.Drawing.Size(167, 67)
        Me.btnShell.TabIndex = 7
        Me.btnShell.Text = "Shell Sort"
        Me.btnShell.UseVisualStyleBackColor = False
        '
        'MenuAlgoritmos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyectoFinalVB.My.Resources.Resources.MenuAlgoritmos
        Me.ClientSize = New System.Drawing.Size(784, 485)
        Me.Controls.Add(Me.btnShell)
        Me.Controls.Add(Me.btnRadix)
        Me.Controls.Add(Me.btnCounting)
        Me.Controls.Add(Me.btnCocktail)
        Me.Controls.Add(Me.btnBubble)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblIns)
        Me.Name = "MenuAlgoritmos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Algoritmos de Ordenamiento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblIns As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnBubble As Button
    Friend WithEvents btnCocktail As Button
    Friend WithEvents btnCounting As Button
    Friend WithEvents btnRadix As Button
    Friend WithEvents btnShell As Button
End Class
