<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTipoTramite
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
        Me.dgvTipoTramite = New System.Windows.Forms.DataGridView()
        Me.cboRubro = New System.Windows.Forms.ComboBox()
        Me.btnIngresarTipoTramite = New System.Windows.Forms.Button()
        Me.txtID_tipoTramite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescrepcion = New System.Windows.Forms.TextBox()
        CType(Me.dgvTipoTramite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTipoTramite
        '
        Me.dgvTipoTramite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTipoTramite.Location = New System.Drawing.Point(12, 73)
        Me.dgvTipoTramite.Name = "dgvTipoTramite"
        Me.dgvTipoTramite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipoTramite.Size = New System.Drawing.Size(347, 306)
        Me.dgvTipoTramite.TabIndex = 0
        '
        'cboRubro
        '
        Me.cboRubro.FormattingEnabled = True
        Me.cboRubro.Items.AddRange(New Object() {"inmobiliaria", "fiscales", "automotor"})
        Me.cboRubro.Location = New System.Drawing.Point(12, 32)
        Me.cboRubro.Name = "cboRubro"
        Me.cboRubro.Size = New System.Drawing.Size(121, 21)
        Me.cboRubro.TabIndex = 1
        Me.cboRubro.Text = "inmobiliaria"
        '
        'btnIngresarTipoTramite
        '
        Me.btnIngresarTipoTramite.Location = New System.Drawing.Point(12, 449)
        Me.btnIngresarTipoTramite.Name = "btnIngresarTipoTramite"
        Me.btnIngresarTipoTramite.Size = New System.Drawing.Size(347, 23)
        Me.btnIngresarTipoTramite.TabIndex = 2
        Me.btnIngresarTipoTramite.Text = "Ingresar tipo tramite"
        Me.btnIngresarTipoTramite.UseVisualStyleBackColor = True
        '
        'txtID_tipoTramite
        '
        Me.txtID_tipoTramite.Location = New System.Drawing.Point(150, 395)
        Me.txtID_tipoTramite.Name = "txtID_tipoTramite"
        Me.txtID_tipoTramite.Size = New System.Drawing.Size(37, 20)
        Me.txtID_tipoTramite.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "codigo de tipo Tramite:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "descripcion  tipo Tramite:"
        '
        'txtDescrepcion
        '
        Me.txtDescrepcion.Location = New System.Drawing.Point(150, 421)
        Me.txtDescrepcion.Name = "txtDescrepcion"
        Me.txtDescrepcion.Size = New System.Drawing.Size(209, 20)
        Me.txtDescrepcion.TabIndex = 5
        '
        'frmTipoTramite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 484)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescrepcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtID_tipoTramite)
        Me.Controls.Add(Me.btnIngresarTipoTramite)
        Me.Controls.Add(Me.cboRubro)
        Me.Controls.Add(Me.dgvTipoTramite)
        Me.Name = "frmTipoTramite"
        Me.Text = "frmTipoTramite"
        CType(Me.dgvTipoTramite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTipoTramite As DataGridView
    Friend WithEvents cboRubro As ComboBox
    Friend WithEvents btnIngresarTipoTramite As Button
    Friend WithEvents txtID_tipoTramite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescrepcion As TextBox
End Class
