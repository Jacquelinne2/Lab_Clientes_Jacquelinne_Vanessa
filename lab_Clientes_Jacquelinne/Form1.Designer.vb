<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.MaskedTextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(27, 420)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 23)
        Me.btnguardar.TabIndex = 0
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(125, 420)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 1
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(223, 420)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(75, 23)
        Me.btneliminar.TabIndex = 2
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(257, 89)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnmostrar.TabIndex = 3
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(70, 89)
        Me.txtid.Name = "txtid"
        Me.txtid.PlaceholderText = "ID CLIENTE"
        Me.txtid.Size = New System.Drawing.Size(171, 23)
        Me.txtid.TabIndex = 4
        '
        'txtdireccion
        '
        Me.txtdireccion.Location = New System.Drawing.Point(70, 238)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.PlaceholderText = "DIRECCION"
        Me.txtdireccion.Size = New System.Drawing.Size(262, 23)
        Me.txtdireccion.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(70, 369)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.PlaceholderText = "EMAIL"
        Me.txtemail.Size = New System.Drawing.Size(262, 23)
        Me.txtemail.TabIndex = 8
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(70, 142)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PlaceholderText = "NOMBRE CLIENTE"
        Me.txtnombre.Size = New System.Drawing.Size(262, 23)
        Me.txtnombre.TabIndex = 9
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(70, 323)
        Me.txttelefono.Mask = "0000-0000"
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(262, 23)
        Me.txttelefono.TabIndex = 10
        '
        'txtapellido
        '
        Me.txtapellido.Location = New System.Drawing.Point(70, 190)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.PlaceholderText = "APELLIDO CLIENTE"
        Me.txtapellido.Size = New System.Drawing.Size(262, 23)
        Me.txtapellido.TabIndex = 11
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(313, 420)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 12
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(158, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "CLIENTES"
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(70, 277)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(262, 23)
        Me.txtfecha.TabIndex = 14
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 536)
        Me.Controls.Add(Me.txtfecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtdireccion)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "Form1"
        Me.Text = "Lab Jacquelinne Vanessa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnguardar As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnmostrar As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txttelefono As MaskedTextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfecha As MaskedTextBox
End Class
