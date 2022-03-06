
Imports System.Data.SQLite

Public Class DatabaseMake
    Private Const connectionSTR As String = ("Data Source=C:\Account Basic\ACCOUNTBOOK.db")
    Private Sub DatabaseMake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currencyList()
    End Sub

    ''===========================================================
    ''============Currency=======================================
    Public Sub currencyList()
        Dim Ringgit As String = "RM"
        Currency_List.Items.Add("RM")
        Currency_List.Items.Add("USD")
    End Sub
    ''===========================================================
    ''===write company name to database and other value


    ''===================================================

    ''==================================================
    '' write to app setiing string connection
    Public Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles CompanyName.TextChanged
        '' split and create auto name for database
        Dim str As String
        Dim texboxValue As String
        texboxValue = CompanyName.Text
        str = texboxValue.Split(" ").First()
        AutoDbName.Text = "SLite_" & str
    End Sub

    Private Sub Save_Detail_Button_Click(sender As Object, e As EventArgs) Handles Save_Detail_Button.Click
        Dim writecon As New SQLiteConnection(connectionSTR)
        Dim writecom As New SQLiteCommand("INSERT INTO MyCompany (MyCompany_Id, CompanyName, CompanyRegistration, CompanyAddress, CompanyTelephone, Tax, Currency) VALUES('" + AutoDbName.Text + "','" + CompanyName.Text + "','" + TextBox_Registration.Text + "','" + Address.Text + "','" + TextBox_Telephone.Text + "','" + TextBox_Tax.Text + "','" + Currency_List.Text + "')", writecon)
        writecon.Open()
        Try

            writecom.ExecuteNonQuery()
            MessageBox.Show("Task Completed. You can now close this window to continue")
        Catch ex As Exception
            MsgBox("Error entering Supplier Data", MsgBoxStyle.OkOnly)
        End Try


    End Sub
End Class
