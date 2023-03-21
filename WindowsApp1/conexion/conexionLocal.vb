Imports MySql.Data.MySqlClient
Module conexionLocal
    Public connLocal As MySqlConnection
    Public Sub abrirDbLocal()
        connLocal = New MySqlConnection
        Try
            connLocal.ConnectionString = "Server=localhost;Database=tramites_gestoria;user=root;password=walter;SslMode=0;"
            connLocal.Open()
            'MsgBox("coneccion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub cerrarDbLocal()
        connLocal.Close()
    End Sub

End Module
