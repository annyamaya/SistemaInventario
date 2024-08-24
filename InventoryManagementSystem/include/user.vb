﻿Imports MySql.Data.MySqlClient
Module user
    Public con As MySqlConnection = mysqldb()

    Public Sub login(ByVal username As Object, ByVal pass As Object)
        Try

            con.Open()
            reloadtxt("SELECT * FROM user WHERE user_name= '" & username.text & "' and pass = sha1('" & pass.text & "')")


            If dt.Rows.Count > 0 Then
                If dt.Rows(0).Item("type") = "Administrator" Then
                    MsgBox("Bienvenid@ " & dt.Rows(0).Item("name"))
                    enable_disable(True)

                    With Form1
                        .ts_Login.Text = "SALIR"
                        .ts_Login.Image = My.Resources.salir
                        .ts_ManageUser.Visible = True
                        LoginForm1.Close()
                    End With
                ElseIf dt.Rows(0).Item("type") = "Staff" Then
                    MsgBox("Bienvenid@ " & dt.Rows(0).Item("name"))
                    enable_disable(True)
                    With Form1
                        .ts_Login.Text = "SALIR"
                        .ts_Login.Image = My.Resources.salir
                        .ts_ManageUser.Visible = False
                        LoginForm1.Close()
                    End With
                End If

            Else
                MsgBox("Usuario no existe!", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        da.Dispose()
    End Sub

    Public Sub append(ByVal sql As String, ByVal field As String, ByVal txt As Object)
        reloadtxt(sql)
        Try
            Dim r As DataRow
            txt.AutoCompleteCustomSource.Clear()
            For Each r In dt.Rows
                txt.AutoCompleteCustomSource.Add(r.Item(field).ToString)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       

    End Sub
End Module
