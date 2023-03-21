Imports MySql.Data.MySqlClient

Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGrillaClientes()
    End Sub
    Private Sub cargarGrillaClientes()
        Try
            abrirDB()
            'abrirDbLocal()
            'Dim adapter As New MySqlDataAdapter("SELECT * From tramites", conexionLocal.connLocal)
            Dim adapter As New MySqlDataAdapter("SELECT * From clientes", conexionBD.Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            '
            dgvClientes.DataSource = table

            'cerrarDbLocal()
            cerrarDB()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class