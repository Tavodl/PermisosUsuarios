<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEdit
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
        txtUsuario = New TextBox()
        txtApellido1 = New TextBox()
        txtApellido2 = New TextBox()
        txtNombre1 = New TextBox()
        txtNombre2 = New TextBox()
        cmbEstado = New ComboBox()
        btnSave = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        SuspendLayout()
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(34, 60)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(199, 23)
        txtUsuario.TabIndex = 0
        ' 
        ' txtApellido1
        ' 
        txtApellido1.Location = New Point(34, 111)
        txtApellido1.Name = "txtApellido1"
        txtApellido1.Size = New Size(199, 23)
        txtApellido1.TabIndex = 1
        ' 
        ' txtApellido2
        ' 
        txtApellido2.Location = New Point(250, 111)
        txtApellido2.Name = "txtApellido2"
        txtApellido2.Size = New Size(199, 23)
        txtApellido2.TabIndex = 2
        ' 
        ' txtNombre1
        ' 
        txtNombre1.Location = New Point(250, 60)
        txtNombre1.Name = "txtNombre1"
        txtNombre1.Size = New Size(199, 23)
        txtNombre1.TabIndex = 3
        ' 
        ' txtNombre2
        ' 
        txtNombre2.Location = New Point(468, 60)
        txtNombre2.Name = "txtNombre2"
        txtNombre2.Size = New Size(199, 23)
        txtNombre2.TabIndex = 4
        ' 
        ' cmbEstado
        ' 
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(468, 111)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(121, 23)
        cmbEstado.TabIndex = 6
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(285, 161)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 35)
        btnSave.TabIndex = 7
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 8
        Label1.Text = "Usuario *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(250, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 9
        Label2.Text = "Primer Nombre *"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(468, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 10
        Label3.Text = "Segundo Nombre"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(250, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 11
        Label4.Text = "Segundo Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(34, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 12
        Label5.Text = "Primer Apellido *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(11, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 30)
        Label6.TabIndex = 13
        Label6.Text = "Editar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(468, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 27
        Label7.Text = "Estado *"
        ' 
        ' FormEdit
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(708, 223)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSave)
        Controls.Add(cmbEstado)
        Controls.Add(txtNombre2)
        Controls.Add(txtNombre1)
        Controls.Add(txtApellido2)
        Controls.Add(txtApellido1)
        Controls.Add(txtUsuario)
        Name = "FormEdit"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
