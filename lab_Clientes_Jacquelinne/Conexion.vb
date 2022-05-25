Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Module Conexion
    Public conect As New SqlConnection("Data Source=DESKTOP-8UADPGN\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True")
    Sub Abrir_Conexion()
        If conect.State = 0 Then
            conect.Open()
        End If

    End Sub

    Sub Cerrar_Conexion()
        If conect.State = 1 Then
            conect.Close()
        End If

    End Sub
End Module
