Imports MySql.Data.MySqlClient

Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Try
            abrirDB()
            Dim adapter As New MySqlDataAdapter("SELECT * From tramites", Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            cboIdTipoTramite.DataSource = table
            DataGridView1.DataSource = table

            cboIdTipoTramite.ValueMember = "id_tipoTramite"
            cboIdTipoTramite.DisplayMember = "id_tipoTramite"

            cboIdCliente.ValueMember = "id_cliente"
            cboIdCliente.DisplayMember = "id_cliente"

            cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            abrirDB()
            'abrirDbLocal()
            'Dim adapter As New MySqlDataAdapter("SELECT * From tramites", conexionLocal.connLocal)
            Dim adapter As New MySqlDataAdapter("SELECT * From clientes", conexionBD.Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            '
            DataGridView2.DataSource = table

            'cerrarDbLocal()
            cerrarDB()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            abrirDbLocal()
            Dim adapter As New MySqlDataAdapter("SELECT * From clientes", conexionLocal.connLocal)
            Dim table As New DataTable

            adapter.Fill(table)


            ComboBox2.DataSource = table
            'DataGridView2.DataSource = table

            ComboBox2.ValueMember = "id_cliente"
            ComboBox2.DisplayMember = "nombre"

            cerrarDbLocal()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            abrirDbLocal()
            Dim adapter As New MySqlDataAdapter("SELECT * From clientes", conexionLocal.connLocal)
            Dim table As New DataTable

            adapter.Fill(table)


            ComboBox2.DataSource = table
            'DataGridView2.DataSource = table

            ComboBox2.ValueMember = "id_cliente"
            ComboBox2.DisplayMember = "id_cliente"

            cerrarDbLocal()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged


        TextBox1.Text = ComboBox2.SelectedValue.ToString()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'validar vacios
        Dim vErrores As String = ""

        'validar tipo tramite
        If (cboIdTipoTramite.Text.Trim = "") Then
            vErrores &= "el combo tipo tramite, no debe estar vacio" & vbCrLf
        End If

        'validar codigo cliente
        If (cboIdCliente.Text.Trim = "") Then
            vErrores &= "el combo id cliente, no debe estar vacio" & vbCrLf
        End If

        'validar presupuesto inicial
        If (txtPresupuestoInicial.Text.Trim = "") Then
            vErrores &= "el Presupuesto Inicial, no debe estar vacio" & vbCrLf
        End If

        'validar seña
        If (txtSenia.Text.Trim = "") Then
            vErrores &= "la seña, no debe estar vacio" & vbCrLf
        End If

        'validar costo total
        If (txtCostoTotal.Text.Trim = "") Then
            vErrores &= "el costo total, no debe estar vacio" & vbCrLf
        End If

        'validar id empleado
        If (cboIdEmpleado.Text.Trim = "") Then
            vErrores &= "el combo empleado, no debe estar vacio" & vbCrLf
        End If

        'validar estado tramite
        If (txtEstadoTramite.Text.Trim = "") Then
            vErrores &= "el estado tramite, no debe estar vacio" & vbCrLf
        End If

        '----------------------------------------------------------------
        If (vErrores <> "") Then
            MsgBox(vErrores, MsgBoxStyle.Information, "Errores")
        Else
            'ingresar datos a la base de datos 

            Try
                conexionBD.abrirDB()
                Dim vQuery As String = "insert into tramites 
                (id_tipoTramite, id_cliente, fechaInicio, fechaFinalizacion, presupuestoInicial, senia, costoTotal, id_empleado, estadoTramite)
                values (@tipoTramite, @idCliente, @fechaInicio, @fechaFinalizacion, @presupuestoInicial, @senia, @costoTotal, @idEmpleado, @estadoTramite)"
                Dim vCmd As MySqlCommand
                vCmd = New MySqlCommand(vQuery, conexionBD.Mysqlconn)
                'vCmd.Connection = connLocal
                'vCmd.CommandText = CommandType.Text
                'vCmd.CommandText = vQuery

                vCmd.Parameters.AddWithValue("@tipoTramite", Integer.Parse(cboIdTipoTramite.Text))
                vCmd.Parameters.AddWithValue("@idCliente", Integer.Parse(cboIdCliente.Text))
                vCmd.Parameters.AddWithValue("@fechaInicio", Convert.ToDateTime(dtpFechaInicio.Value))
                vCmd.Parameters.AddWithValue("@fechaFinalizacion", Convert.ToDateTime(dtpFechaFinalizacion.Value))
                vCmd.Parameters.AddWithValue("@presupuestoInicial", Double.Parse(txtPresupuestoInicial.Text))
                vCmd.Parameters.AddWithValue("@senia", Double.Parse(txtSenia.Text))
                vCmd.Parameters.AddWithValue("@costoTotal", Double.Parse(txtCostoTotal.Text))
                vCmd.Parameters.AddWithValue("@idEmpleado", Integer.Parse(cboIdEmpleado.Text))
                vCmd.Parameters.AddWithValue("@estadoTramite", txtEstadoTramite.Text)

                vCmd.CommandTimeout = 300

                vCmd.ExecuteNonQuery()

                MsgBox("Tramite ingresado", MsgBoxStyle.Information, "TRAMITE")


                conexionBD.cerrarDB()
                limpiarCajas()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        End If

    End Sub

    Private Sub btnCargarGrilla_Click(sender As Object, e As EventArgs) Handles btnCargarGrilla.Click
        cargarGrillaTramites()
        limpiarCajas()
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim cartel As DialogResult
        btnModificar.Enabled = True
        If e.ColumnIndex = Me.DataGridView1.Columns.Item("delete").Index Then

            'me guardo ok o cancel
            cartel = MessageBox.Show("ELIMINAR TRAMITE", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If cartel = DialogResult.OK Then

                Try
                    conexionBD.abrirDB()
                    Dim query As String = "delete from tramites where id_tramite=@id"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, conexionBD.Mysqlconn)

                    cmd.Parameters.AddWithValue("@id", DataGridView1.SelectedCells.Item(2).Value) 'de la grilla pocision 3

                    cmd.ExecuteNonQuery()
                    conexionBD.cerrarDB()

                    MsgBox("se elimino el registro")

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        Else
            Try
                If e.ColumnIndex = Me.DataGridView1.Columns.Item("update").Index Then
                    DataGridView1.Rows(e.RowIndex).Selected = True
                    DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(0)
                    'Dim cartel As DialogResult
                    'me guardo ok o cancel
                    cartel = MessageBox.Show("cargar registro a editar", "Editar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                    If cartel = DialogResult.OK Then
                        btnAgregar.Enabled = False

                        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                        'txtIdTramite.Text = DataGridView1.SelectedCells.Item(2).Value
                        txtIdTramite.Text = CStr(row.Cells(2).Value)
                        'DataGridView1.CurrentCell = DataGridView1.Rows(e.RowIndex).Cells(0)

                        'cboIdTipoTramite.Text = DataGridView1.SelectedCells.Item(3).Value
                        cboIdTipoTramite.Text = CStr(row.Cells(3).Value)

                        'TextBox1.Text = CStr(row.Cells(0).Value)
                        cboIdCliente.Text = CStr(row.Cells(4).Value)

                        'dtpFechaInicio.Value = DataGridView1.SelectedCells.Item(5).Value
                        dtpFechaInicio.Value = CStr(row.Cells(5).Value)

                        'dtpFechaFinalizacion.Value = DataGridView1.SelectedCells.Item(6).Value
                        dtpFechaFinalizacion.Value = CStr(row.Cells(6).Value)

                        'txtPresupuestoInicial.Text = DataGridView1.SelectedCells.Item(7).Value
                        txtPresupuestoInicial.Text = CStr(row.Cells(7).Value)

                        'txtSenia.Text = DataGridView1.SelectedCells.Item(8).Value
                        txtSenia.Text = CStr(row.Cells(8).Value)

                        'txtCostoTotal.Text = DataGridView1.SelectedCells.Item(9).Value
                        txtCostoTotal.Text = CStr(row.Cells(9).Value)

                        'cboIdEmpleado.Text = DataGridView1.SelectedCells.Item(10).Value
                        cboIdEmpleado.Text = CStr(row.Cells(10).Value)

                        'txtEstadoTramite.Text = DataGridView1.SelectedCells.Item(11).Value
                        txtEstadoTramite.Text = CStr(row.Cells(11).Value)

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrillaTramites()
        btnModificar.Enabled = False


    End Sub
    Private Sub cargarGrillaTramites()
        Try
            conexionBD.abrirDB()
            Dim adapter As New MySqlDataAdapter("SELECT * From tramites", conexionBD.Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            cboIdTipoTramite.DataSource = table
            DataGridView1.DataSource = table
            cboIdCliente.DataSource = table

            cboIdTipoTramite.ValueMember = "id_tipoTramite"
            cboIdTipoTramite.DisplayMember = "id_tipoTramite"
            cboIdCliente.ValueMember = "id_cliente"
            cboIdCliente.DisplayMember = "id_cliente"



            conexionBD.cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        btnAgregar.Enabled = True
        btnModificar.Enabled = False
        Try
            conexionBD.abrirDB()
            Dim consulta As String = "update tramites SET id_tipoTramite=@tipoTramite, id_cliente=@idCliente, fechaInicio=@fechaInicio,
                                      fechaFinalizacion=@fechaFinalizacion, presupuestoInicial=@presupuestoInicial, senia= @senia,
                                      costoTotal=@costoTotal,id_empleado=@idEmpleado, estadoTramite=@estadoTramite
                                      where id_tramite=@ID"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(consulta, conexionBD.Mysqlconn)

            cmd.Parameters.AddWithValue("@ID", Integer.Parse(txtIdTramite.Text))

            cmd.Parameters.AddWithValue("@tipoTramite", Integer.Parse(cboIdTipoTramite.Text))
            cmd.Parameters.AddWithValue("@idCliente", Integer.Parse(cboIdCliente.Text))
            cmd.Parameters.AddWithValue("@fechaInicio", Convert.ToDateTime(dtpFechaInicio.Value))
            cmd.Parameters.AddWithValue("@fechaFinalizacion", Convert.ToDateTime(dtpFechaFinalizacion.Value))
            cmd.Parameters.AddWithValue("@presupuestoInicial", Double.Parse(txtPresupuestoInicial.Text))
            cmd.Parameters.AddWithValue("@senia", Double.Parse(txtSenia.Text))
            cmd.Parameters.AddWithValue("@costoTotal", Double.Parse(txtCostoTotal.Text))
            cmd.Parameters.AddWithValue("@idEmpleado", Integer.Parse(cboIdEmpleado.Text))
            cmd.Parameters.AddWithValue("@estadoTramite", txtEstadoTramite.Text)

            cmd.ExecuteNonQuery()

            MsgBox("Tramite Modificado", MsgBoxStyle.Information, "MODIFICAR")


            conexionBD.cerrarDB()
            cargarGrillaTramites()
            limpiarCajas()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiarCajas()
        txtIdTramite.Text = ""
        cboIdTipoTramite.Text = ""
        cboIdCliente.Text = ""
        dtpFechaInicio.Value = Now()
        dtpFechaFinalizacion.Value = Now()
        txtPresupuestoInicial.Text = ""
        txtSenia.Text = ""
        txtCostoTotal.Text = ""
        cboIdEmpleado.Text = ""
        txtEstadoTramite.Text = ""
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Clientes.ShowDialog()
    End Sub
    Private Sub cargarcomboClientes()

    End Sub

    Private Sub btnCargaCliente_Click(sender As Object, e As EventArgs) Handles btnCargaCliente.Click
        agregarCliente.ShowDialog()
    End Sub

    Private Sub btnAgregarTipoTramite_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoTramite.Click
        frmTipoTramite.ShowDialog()
    End Sub
End Class
