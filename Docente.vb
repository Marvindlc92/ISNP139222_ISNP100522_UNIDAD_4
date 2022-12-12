Public Class Docente
    Dim c As New Conexion

    Private codigoDocente As Integer
    Private nombreDocente As String
    Private apellidoDocente As String
    Private pagina As Page

    Public Property codDocente() As Integer
        Get
            Return codigoDocente
        End Get
        Set(value As Integer)
            codigoDocente = value
        End Set
    End Property

    Public Property nomDocente() As String
        Get
            Return nombreDocente
        End Get
        Set(value As String)
            nombreDocente = value
        End Set
    End Property

    Public Property apeDocente() As String
        Get
            Return apellidoDocente
        End Get
        Set(value As String)
            apellidoDocente = value
        End Set
    End Property

    Public Function listarRegistros() As DataTable
        c.strconexion.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codDocente, nomDocente, apeDocente FROM docente"
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function

    Public Sub guardar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "INSERT INTO docente VALUES('" & codDocente & "','" & nomDocente & "','" & apeDocente & "')"
                c.result = c.cmd.ExecuteNonQuery
            End With
            If c.result = 0 Then
                MsgBox("No se ha podido guardar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro guardado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(" No se ha podido guardar el Registro", MsgBoxStyle.Critical)
        End Try
        c.strcon.Close()
    End Sub

    Public Function mostrarRegistro() As DataTable
        c.strcon.Open()
        With c.cmd
            .Connection = c.strcon
            .CommandText = "SELECT codDocente,nomDocente,apeDocente FROM Docente WHERE codDocente = '" & codDocente & "'"
            'c.result = c.cmd.ExecuteNonQuery
        End With
        c.da.SelectCommand = c.cmd
        c.da.Fill(c.dt)
        Return c.dt
    End Function

    Public Sub editar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "UPDATE docente SET nomDocente ='" & nomDocente & "', apeDocente = '" & apeDocente & "' WHERE codDocente = '" & codDocente & "' "
                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido actualizar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub

    Public Sub eliminar()
        Try
            c.strcon.Open()
            With c.cmd
                .Connection = c.strcon
                .CommandText = "DELETE FROM docente WHERE codDocente = '" & codDocente & "'"
                c.result = c.cmd.ExecuteNonQuery
            End With

            If c.result = 0 Then
                MsgBox("No se ha podido Borrar", MsgBoxStyle.Critical)
            Else
                MsgBox("Registro Borrado exitosamente", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        c.strcon.Close()
    End Sub
End Class
