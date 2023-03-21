Imports MySql.Data.MySqlClient
Module conexionBD
    Public Mysqlconn As MySqlConnection

    Public Sub abrirDB()
        Mysqlconn = New MySqlConnection
        Try
            'Mysqlconn.ConnectionString = "Server=etu5rvvowonj.aws-sa-east-1-1.psdb.cloud;Database=tramites_gestoria;user=r0ykizwijtfe;password=pscale_pw_X41vys2ylePwpYx5c2hQ17SSn_5SDGTrq777zQSS0dg;SslMode=VerifyFull;"
            'Mysqlconn.Open()
            'MsgBox("coneccion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub cerrarDB()
        Mysqlconn.Close()
    End Sub

End Module
