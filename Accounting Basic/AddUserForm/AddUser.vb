Imports System.Data.SQLite

Public Class AddUser
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"

    Private Sub Button_adduser_Click(sender As Object, e As EventArgs) Handles Button_adduser.Click
        Using SLITECONNECTION_M As New SQLiteConnection(ConnectionSTR)
            Using SLITECOMMAND As New SQLiteCommand("Insert Into Security (Log_Id, Name, Password) Values('" + TextBox_username.Text + "','" + TextBox_fullname.Text + "', '" + TextBox_password.Text + "')", SLITECONNECTION_M)
                SLITECONNECTION_M.Open()
                Try
                    SLITECOMMAND.ExecuteNonQuery()
                Catch ex As Exception

                End Try
                MsgBox("Success added", MsgBoxStyle.OkOnly)
                If DialogResult.OK Then
                    TextBox_username.Clear()
                    TextBox_fullname.Clear()
                    TextBox_password.Clear()

                End If
            End Using
        End Using
    End Sub


End Class