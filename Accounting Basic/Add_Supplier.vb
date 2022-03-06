Imports System.Data.SQLite

Public Class Add_Supplier
    Private Const connectionSTR As String = ("Data Source=C:\Account Basic\ACCOUNTBOOK.db")
    Private Sub TextBox_add_supplier_companyname_TextChanged(sender As Object, e As EventArgs) Handles TextBox_add_supplier_companyname.TextChanged
        '' split and create auto name for database
        Dim str As String
        Dim texboxValue As String
        texboxValue = TextBox_add_supplier_companyname.Text
        str = texboxValue.Split(" ").First()
        TextBox_supplier_ID.Text = "SLite_" & str
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim writecon As New SQLiteConnection(connectionSTR)
        Dim writecom As New SQLiteCommand("INSERT INTO Supplier (Company_Id,Registration, CompanyName, CompanyAddress, CompanyTelephone, CashFlow) VALUES('" + TextBox_supplier_ID.Text + "','" + TextBox_add_supplier_companyregistration.Text + "','" + TextBox_add_supplier_companyname.Text + "','" + TextBox_add_supplier_address.Text + "','" + TextBox_add_supplier_telephone.Text + "','" + TextBox_Supplier_add_cash.Text + "')", writecon)
        writecon.Open()
        Try

            writecom.ExecuteNonQuery()
            MessageBox.Show("Task Completed. You can now close this window to continue")
        Catch ex As Exception
            MsgBox("Error entering Supplier Data", MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class