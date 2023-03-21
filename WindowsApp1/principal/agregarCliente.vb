Imports MySql.Data.MySqlClient

Public Class agregarCliente
    Dim codigo As Integer
    Dim Nombre As String
    Dim Apellido As String
    Private Sub agregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            abrirDB()

            Dim adapter As New MySqlDataAdapter("SELECT * From clientes", conexionBD.Mysqlconn)
            ' Dim table As New DataTable
            Dim dtset = New DataSet
            adapter.Fill(dtset)

            'cboApellidoCliente.DataSource = dtset
            If dtset.Tables(0).Rows.Count <> 0 Then
                For i = 0 To dtset.Tables(0).Rows.Count - 1
                    codigo = dtset.Tables(0).Rows(i).Item("id_cliente")
                    Nombre = dtset.Tables(0).Rows(i).Item("nombre")
                    Apellido = dtset.Tables(0).Rows(i).Item("apellido")
                    cboApellidoCliente.Items.Add(Apellido & " - " & Nombre)
                Next

            End If
            cboApellidoCliente.ValueMember = "id_cliente"
            'cboApellidoCliente.DisplayMember = "apellido"
            cerrarDB()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cboApellidoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboApellidoCliente.SelectedIndexChanged
        txtIdCliente.Text = cboApellidoCliente.SelectedIndex + 1

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.cboIdCliente.Text = txtIdCliente.Text
        Close()

    End Sub
End Class