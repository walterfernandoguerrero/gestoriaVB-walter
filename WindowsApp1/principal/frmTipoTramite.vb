Imports MySql.Data.MySqlClient

Public Class frmTipoTramite
    Private Sub frmTipoTramite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexionBD.abrirDB()
            Dim adapter As New MySqlDataAdapter("SELECT  id_tipoTramite, nombre, rubro from tipo_de_tramite", conexionBD.Mysqlconn)
            Dim table As New DataTable

            'adapter.SelectCommand.Parameters.AddWithValue("@rubro", cboRubro.Text)


            adapter.Fill(table)

            cboRubro.DataSource = table
            cboRubro.ValueMember = "id_tipoTramite"
            cboRubro.DisplayMember = "rubro"

            conexionBD.cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub cboRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRubro.SelectedIndexChanged
        Try
            conexionBD.abrirDB()
            Dim adapter As New MySqlDataAdapter("SELECT id_tipoTramite, nombre, rubro from tipo_de_tramite where rubro = '" & cboRubro.Text & "'", conexionBD.Mysqlconn)
            Dim table As New DataTable

            ' adapter.SelectCommand.Parameters.AddWithValue("@filtro", cboRubro.Text)


            adapter.Fill(table)
            dgvTipoTramite.DataSource = table
            conexionBD.cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnIngresarTipoTramite_Click(sender As Object, e As EventArgs) Handles btnIngresarTipoTramite.Click
        Form1.cboIdTipoTramite.Text = txtID_tipoTramite.Text
        Close()
    End Sub

    Private Sub dgvTipoTramite_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTipoTramite.CellContentClick
        txtID_tipoTramite.Text = dgvTipoTramite.SelectedCells.Item(0).Value
        txtDescrepcion.Text = dgvTipoTramite.SelectedCells.Item(1).Value
    End Sub


End Class