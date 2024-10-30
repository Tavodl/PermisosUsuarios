<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAsignaPermiso
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
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label8 = New Label()
        btnSave = New Button()
        cmbEstado = New ComboBox()
        txtNombre2 = New TextBox()
        txtNombre1 = New TextBox()
        txtApellido2 = New TextBox()
        txtApellido1 = New TextBox()
        txtUsuario = New TextBox()
        DataGridView1 = New DataGridView()
        codigo = New DataGridViewTextBoxColumn()
        descripcion = New DataGridViewTextBoxColumn()
        seg_insertar = New DataGridViewCheckBoxColumn()
        seg_editar = New DataGridViewCheckBoxColumn()
        seg_borrar = New DataGridViewCheckBoxColumn()
        seg_buscar = New DataGridViewCheckBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(450, 93)
        Label7.Name = "Label7"
        Label7.Size = New Size(50, 15)
        Label7.TabIndex = 41
        Label7.Text = "Estado *"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(246, 30)
        Label6.TabIndex = 40
        Label6.Text = "Asignacion de permisos"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 15)
        Label5.TabIndex = 39
        Label5.Text = "Primer Apellido *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(232, 93)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 15)
        Label4.TabIndex = 38
        Label4.Text = "Segundo Apellido"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(450, 42)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 37
        Label3.Text = "Segundo Nombre"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(232, 42)
        Label2.Name = "Label2"
        Label2.Size = New Size(97, 15)
        Label2.TabIndex = 36
        Label2.Text = "Primer Nombre *"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(16, 42)
        Label8.Name = "Label8"
        Label8.Size = New Size(55, 15)
        Label8.TabIndex = 35
        Label8.Text = "Usuario *"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(623, 99)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 35)
        btnSave.TabIndex = 34
        btnSave.Text = "Guardar"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' cmbEstado
        ' 
        cmbEstado.FormattingEnabled = True
        cmbEstado.Location = New Point(450, 111)
        cmbEstado.Name = "cmbEstado"
        cmbEstado.Size = New Size(121, 23)
        cmbEstado.TabIndex = 33
        ' 
        ' txtNombre2
        ' 
        txtNombre2.Location = New Point(450, 60)
        txtNombre2.Name = "txtNombre2"
        txtNombre2.Size = New Size(199, 23)
        txtNombre2.TabIndex = 32
        ' 
        ' txtNombre1
        ' 
        txtNombre1.Location = New Point(232, 60)
        txtNombre1.Name = "txtNombre1"
        txtNombre1.Size = New Size(199, 23)
        txtNombre1.TabIndex = 31
        ' 
        ' txtApellido2
        ' 
        txtApellido2.Location = New Point(232, 111)
        txtApellido2.Name = "txtApellido2"
        txtApellido2.Size = New Size(199, 23)
        txtApellido2.TabIndex = 30
        ' 
        ' txtApellido1
        ' 
        txtApellido1.Location = New Point(16, 111)
        txtApellido1.Name = "txtApellido1"
        txtApellido1.Size = New Size(199, 23)
        txtApellido1.TabIndex = 29
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(16, 60)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(199, 23)
        txtUsuario.TabIndex = 28
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {codigo, descripcion, seg_insertar, seg_editar, seg_borrar, seg_buscar})
        DataGridView1.Location = New Point(18, 165)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(770, 273)
        DataGridView1.TabIndex = 42
        ' 
        ' codigo
        ' 
        codigo.HeaderText = "Id"
        codigo.Name = "codigo"
        codigo.ReadOnly = True
        ' 
        ' descripcion
        ' 
        descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        descripcion.HeaderText = "Descripcion"
        descripcion.Name = "descripcion"
        descripcion.ReadOnly = True
        descripcion.Resizable = DataGridViewTriState.True
        descripcion.Width = 94
        ' 
        ' seg_insertar
        ' 
        seg_insertar.HeaderText = "Insertar"
        seg_insertar.Name = "seg_insertar"
        seg_insertar.Resizable = DataGridViewTriState.True
        seg_insertar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' seg_editar
        ' 
        seg_editar.HeaderText = "Editar"
        seg_editar.Name = "seg_editar"
        seg_editar.Resizable = DataGridViewTriState.True
        seg_editar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' seg_borrar
        ' 
        seg_borrar.HeaderText = "Borrar"
        seg_borrar.Name = "seg_borrar"
        seg_borrar.Resizable = DataGridViewTriState.True
        seg_borrar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' seg_buscar
        ' 
        seg_buscar.HeaderText = "Buscar"
        seg_buscar.Name = "seg_buscar"
        seg_buscar.Resizable = DataGridViewTriState.True
        seg_buscar.SortMode = DataGridViewColumnSortMode.Automatic
        ' 
        ' FormAsignaPermiso
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridView1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label8)
        Controls.Add(btnSave)
        Controls.Add(cmbEstado)
        Controls.Add(txtNombre2)
        Controls.Add(txtNombre1)
        Controls.Add(txtApellido2)
        Controls.Add(txtApellido1)
        Controls.Add(txtUsuario)
        Name = "FormAsignaPermiso"
        Text = "FormAsignaPermiso"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents txtNombre2 As TextBox
    Friend WithEvents txtNombre1 As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents seg_insertar As DataGridViewCheckBoxColumn
    Friend WithEvents seg_editar As DataGridViewCheckBoxColumn
    Friend WithEvents seg_borrar As DataGridViewCheckBoxColumn
    Friend WithEvents seg_buscar As DataGridViewCheckBoxColumn
End Class
