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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.gboxTramites = New System.Windows.Forms.GroupBox()
        Me.btnCargaCliente = New System.Windows.Forms.Button()
        Me.txtEstadoTramite = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboIdEmpleado = New System.Windows.Forms.ComboBox()
        Me.txtCostoTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSenia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPresupuestoInicial = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaFinalizacion = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboIdCliente = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdTramite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.delete = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.update = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.cboIdTipoTramite = New System.Windows.Forms.ComboBox()
        Me.btnCargarGrilla = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnAgregarTipoTramite = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboxTramites.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 504)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 30)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "tramites"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 453)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(399, 44)
        Me.DataGridView2.TabIndex = 4
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(96, 503)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(223, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 30)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Buscar cliente"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(323, 504)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(36, 29)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(365, 504)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(29, 20)
        Me.TextBox1.TabIndex = 8
        '
        'gboxTramites
        '
        Me.gboxTramites.Controls.Add(Me.btnAgregarTipoTramite)
        Me.gboxTramites.Controls.Add(Me.btnCargaCliente)
        Me.gboxTramites.Controls.Add(Me.txtEstadoTramite)
        Me.gboxTramites.Controls.Add(Me.Label10)
        Me.gboxTramites.Controls.Add(Me.Label9)
        Me.gboxTramites.Controls.Add(Me.cboIdEmpleado)
        Me.gboxTramites.Controls.Add(Me.txtCostoTotal)
        Me.gboxTramites.Controls.Add(Me.Label8)
        Me.gboxTramites.Controls.Add(Me.txtSenia)
        Me.gboxTramites.Controls.Add(Me.Label7)
        Me.gboxTramites.Controls.Add(Me.txtPresupuestoInicial)
        Me.gboxTramites.Controls.Add(Me.Label6)
        Me.gboxTramites.Controls.Add(Me.dtpFechaFinalizacion)
        Me.gboxTramites.Controls.Add(Me.Label5)
        Me.gboxTramites.Controls.Add(Me.dtpFechaInicio)
        Me.gboxTramites.Controls.Add(Me.Label4)
        Me.gboxTramites.Controls.Add(Me.cboIdCliente)
        Me.gboxTramites.Controls.Add(Me.Label3)
        Me.gboxTramites.Controls.Add(Me.txtIdTramite)
        Me.gboxTramites.Controls.Add(Me.Label2)
        Me.gboxTramites.Controls.Add(Me.Label1)
        Me.gboxTramites.Controls.Add(Me.btnModificar)
        Me.gboxTramites.Controls.Add(Me.btnAgregar)
        Me.gboxTramites.Controls.Add(Me.DataGridView1)
        Me.gboxTramites.Controls.Add(Me.cboIdTipoTramite)
        Me.gboxTramites.Controls.Add(Me.btnCargarGrilla)
        Me.gboxTramites.Location = New System.Drawing.Point(12, 12)
        Me.gboxTramites.Name = "gboxTramites"
        Me.gboxTramites.Size = New System.Drawing.Size(943, 435)
        Me.gboxTramites.TabIndex = 9
        Me.gboxTramites.TabStop = False
        Me.gboxTramites.Text = "Tramites: "
        '
        'btnCargaCliente
        '
        Me.btnCargaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaCliente.Location = New System.Drawing.Point(411, 339)
        Me.btnCargaCliente.Name = "btnCargaCliente"
        Me.btnCargaCliente.Size = New System.Drawing.Size(32, 23)
        Me.btnCargaCliente.TabIndex = 11
        Me.btnCargaCliente.Text = ">>"
        Me.btnCargaCliente.UseVisualStyleBackColor = True
        '
        'txtEstadoTramite
        '
        Me.txtEstadoTramite.Location = New System.Drawing.Point(731, 392)
        Me.txtEstadoTramite.Name = "txtEstadoTramite"
        Me.txtEstadoTramite.Size = New System.Drawing.Size(91, 20)
        Me.txtEstadoTramite.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(644, 398)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Estado Tramite:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(489, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "id Empleado:"
        '
        'cboIdEmpleado
        '
        Me.cboIdEmpleado.FormattingEnabled = True
        Me.cboIdEmpleado.Location = New System.Drawing.Point(557, 391)
        Me.cboIdEmpleado.Name = "cboIdEmpleado"
        Me.cboIdEmpleado.Size = New System.Drawing.Size(65, 21)
        Me.cboIdEmpleado.TabIndex = 53
        '
        'txtCostoTotal
        '
        Me.txtCostoTotal.Location = New System.Drawing.Point(410, 391)
        Me.txtCostoTotal.Name = "txtCostoTotal"
        Me.txtCostoTotal.Size = New System.Drawing.Size(73, 20)
        Me.txtCostoTotal.TabIndex = 52
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(349, 394)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "Costo Total:"
        '
        'txtSenia
        '
        Me.txtSenia.Location = New System.Drawing.Point(266, 391)
        Me.txtSenia.Name = "txtSenia"
        Me.txtSenia.Size = New System.Drawing.Size(77, 20)
        Me.txtSenia.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(225, 394)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Seña:"
        '
        'txtPresupuestoInicial
        '
        Me.txtPresupuestoInicial.Location = New System.Drawing.Point(126, 391)
        Me.txtPresupuestoInicial.Name = "txtPresupuestoInicial"
        Me.txtPresupuestoInicial.Size = New System.Drawing.Size(87, 20)
        Me.txtPresupuestoInicial.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 394)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Presupuesto Inicial:"
        '
        'dtpFechaFinalizacion
        '
        Me.dtpFechaFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinalizacion.Location = New System.Drawing.Point(795, 341)
        Me.dtpFechaFinalizacion.Name = "dtpFechaFinalizacion"
        Me.dtpFechaFinalizacion.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaFinalizacion.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(697, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "fecha finalizacion:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(588, 340)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(91, 20)
        Me.dtpFechaInicio.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(303, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "id Cliente:"
        '
        'cboIdCliente
        '
        Me.cboIdCliente.Enabled = False
        Me.cboIdCliente.FormattingEnabled = True
        Me.cboIdCliente.Location = New System.Drawing.Point(362, 339)
        Me.cboIdCliente.Name = "cboIdCliente"
        Me.cboIdCliente.Size = New System.Drawing.Size(43, 21)
        Me.cboIdCliente.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(516, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "fecha Inicio:"
        '
        'txtIdTramite
        '
        Me.txtIdTramite.Enabled = False
        Me.txtIdTramite.Location = New System.Drawing.Point(92, 341)
        Me.txtIdTramite.Name = "txtIdTramite"
        Me.txtIdTramite.Size = New System.Drawing.Size(48, 20)
        Me.txtIdTramite.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Nro Tramite:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(146, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "tipo Tramite:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(856, 271)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(60, 44)
        Me.btnModificar.TabIndex = 37
        Me.btnModificar.Text = "Modicar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(790, 271)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(60, 44)
        Me.btnAgregar.TabIndex = 35
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.delete, Me.update})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 32)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.Size = New System.Drawing.Size(892, 233)
        Me.DataGridView1.TabIndex = 34
        '
        'delete
        '
        Me.delete.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.delete.HeaderText = "DELETE"
        Me.delete.LinkColor = System.Drawing.Color.Red
        Me.delete.Name = "delete"
        Me.delete.Text = "delete"
        Me.delete.UseColumnTextForLinkValue = True
        '
        'update
        '
        Me.update.ActiveLinkColor = System.Drawing.Color.Yellow
        Me.update.HeaderText = "UPDATE"
        Me.update.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.update.Name = "update"
        Me.update.ReadOnly = True
        Me.update.Text = "update"
        Me.update.TrackVisitedState = False
        Me.update.UseColumnTextForLinkValue = True
        '
        'cboIdTipoTramite
        '
        Me.cboIdTipoTramite.Enabled = False
        Me.cboIdTipoTramite.FormattingEnabled = True
        Me.cboIdTipoTramite.Location = New System.Drawing.Point(211, 339)
        Me.cboIdTipoTramite.Name = "cboIdTipoTramite"
        Me.cboIdTipoTramite.Size = New System.Drawing.Size(37, 21)
        Me.cboIdTipoTramite.TabIndex = 33
        '
        'btnCargarGrilla
        '
        Me.btnCargarGrilla.Location = New System.Drawing.Point(724, 271)
        Me.btnCargarGrilla.Name = "btnCargarGrilla"
        Me.btnCargarGrilla.Size = New System.Drawing.Size(60, 44)
        Me.btnCargarGrilla.TabIndex = 32
        Me.btnCargarGrilla.Text = "Cargar "
        Me.btnCargarGrilla.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.Location = New System.Drawing.Point(659, 473)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(87, 24)
        Me.btnClientes.TabIndex = 10
        Me.btnClientes.Text = "clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        'btnAgregarTipoTramite
        '
        Me.btnAgregarTipoTramite.Location = New System.Drawing.Point(255, 339)
        Me.btnAgregarTipoTramite.Name = "btnAgregarTipoTramite"
        Me.btnAgregarTipoTramite.Size = New System.Drawing.Size(32, 23)
        Me.btnAgregarTipoTramite.TabIndex = 57
        Me.btnAgregarTipoTramite.Text = "->"
        Me.btnAgregarTipoTramite.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 540)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.gboxTramites)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Tramites de gestoria"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboxTramites.ResumeLayout(False)
        Me.gboxTramites.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents gboxTramites As GroupBox
    Friend WithEvents txtEstadoTramite As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cboIdEmpleado As ComboBox
    Friend WithEvents txtCostoTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSenia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPresupuestoInicial As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpFechaFinalizacion As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents cboIdCliente As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdTramite As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboIdTipoTramite As ComboBox
    Friend WithEvents btnCargarGrilla As Button
    Friend WithEvents delete As DataGridViewLinkColumn
    Friend WithEvents update As DataGridViewLinkColumn
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnCargaCliente As Button
    Friend WithEvents btnAgregarTipoTramite As Button
End Class
