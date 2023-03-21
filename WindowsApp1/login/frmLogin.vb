Imports MySql.Data.MySqlClient

Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            abrirDB()
            Dim adapter As New MySqlDataAdapter("SELECT * From login", Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            'ComboBox1.DataSource = table
            DataGridView1.DataSource = table

            'ComboBox1.ValueMember = "nombre"
            'ComboBox1.DisplayMember = "nombre"

            cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            abrirDB()

            Dim query As String = "INSERT INTO login (id_usuario, nombre_apellido, email, clave) VALUES (@id, @nomb, @email, @clave) "
            Dim vCmd As MySqlCommand = New MySqlCommand(query, conexionBD.Mysqlconn)

            vCmd.Parameters.AddWithValue("@id", Integer.Parse(txtID.Text))
            vCmd.Parameters.AddWithValue("@nomb", txtNombreApellido.Text)
            vCmd.Parameters.AddWithValue("@email", txtEmail.Text)
            vCmd.Parameters.AddWithValue("@clave", txtClave.Text)

            vCmd.ExecuteNonQuery()

            MsgBox("usuario ingresado correctamente", MsgBoxStyle.Information, "Agregar Usuario")

            cargarLista()

            cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
    Sub cargarLista()
        Try
            abrirDB()

            Dim adapter As New MySqlDataAdapter("SELECT * From login", Mysqlconn)
            Dim table As New DataTable

            adapter.Fill(table)

            'ComboBox1.DataSource = table
            DataGridView1.DataSource = table

            'ComboBox1.ValueMember = "nombre"
            'ComboBox1.DisplayMember = "nombre"

            cerrarDB()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


End Class