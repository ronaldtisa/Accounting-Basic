Imports System.Data.SQLite

Public Class Add_Inventory
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"

    Private Sub Add_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim data2 As DataTable = Load_Company_List()
        AddItem_ComboBox_Company_list.DataSource = data2
        AddItem_ComboBox_Company_list.DisplayMember = "CompanyName"
        AddItem_ComboBox_Company_list.ValueMember = "Company_Id"

    End Sub
    Private Function Load_Company_List() As DataTable
        Dim dataset As New DataTable
        Dim selectstr As String = "SELECT * From Supplier"
        Try
            Using SLiteCon As New SQLiteConnection(ConnectionSTR)
                Using sliteCom As New SQLiteCommand(selectstr, SLiteCon)
                    SLiteCon.Open()
                    Using dataadapt As New SQLiteDataAdapter(sliteCom)
                        dataadapt.Fill(dataset)
                    End Using
                End Using
            End Using
        Catch ex As Exception
        End Try
        Return dataset
    End Function
    Public Sub company_list_autoFill()
        Using SLiteCon As New SQLiteConnection(ConnectionSTR)
            Using SliteCom As New SQLiteCommand("Select Company_Id, Registration, CompanyName, CompanyTelephone, CompanyAddress From Supplier")
                Using dataadapt As New SQLiteDataAdapter
                    Using datatab As New DataTable
                        SLiteCon.Open()
                        SliteCom.ExecuteNonQuery()
                        TextBox_Address.Text = "CompanyAddress"
                        TextBoxTelephone.Text = "CompanyTelephone"
                        TextBoxID.Text = "Company_Id"
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using SLITECONNECTION_M As New SQLiteConnection(ConnectionSTR)
            Using SLITECOMMAND As New SQLiteCommand("Insert Into Inventory (Item_Id, Code, ProductName, Company_Id, Quantity, UnitPrice, UnitTax) Values('" + TextBoxItemId.Text + "','" + TextBox_ItemCode.Text + "', '" + TextBox_ItemName.Text + "','" + TextBoxID.Text + "','" + TextBox_Total_Unit.Text + "','" + TextBox_Unit_Price.Text + "','" + TextBoxtax.Text + "')", SLITECONNECTION_M)
                SLITECONNECTION_M.Open()
                Try
                    SLITECOMMAND.ExecuteNonQuery()
                Catch ex As Exception

                End Try
                MsgBox("Success added", MsgBoxStyle.OkOnly)
                If DialogResult.OK Then
                    TextBox_Total_Unit.Clear()
                    TextBoxID.Clear()
                    TextBoxTelephone.Clear()
                    TextBox_Unit_Price.Clear()
                    TextBox_Address.Clear()
                    TextBox_ItemName.Clear()
                    TextBox_ItemCode.Clear()
                End If

            End Using
        End Using
    End Sub

    Private Sub AddItem_ComboBox_Company_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AddItem_ComboBox_Company_list.SelectedIndexChanged
        Dim dataset3 As New DataTable
        Try
            Using SLiteCon As New SQLiteConnection(ConnectionSTR)
                SLiteCon.Open()
                Dim sliteCom As New SQLiteCommand("SELECT Company_Id, Registration, CompanyAddress, CompanyTelephone From Supplier WHERE CompanyName='" + AddItem_ComboBox_Company_list.Text + "'", SLiteCon)
                Dim dataadapt As SQLiteDataReader = sliteCom.ExecuteReader

                While dataadapt.Read

                    TextBoxID.Text = dataadapt("Company_Id")
                    TextBox_Address.Text = dataadapt("CompanyAddress")
                    TextBoxTelephone.Text = dataadapt("CompanyTelephone")
                End While

            End Using

        Catch ex As Exception
        End Try

    End Sub

    Private Sub TextBox_ItemName_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ItemName.TextChanged
        Dim str As String
        Dim texboxValue As String
        texboxValue = TextBox_ItemName.Text
        str = texboxValue.Split(" ").First()

        Dim str2 As String
        Dim texboxValue2 As String
        texboxValue2 = AddItem_ComboBox_Company_list.Text
        str2 = texboxValue2.Split(" ").First()

        TextBoxItemId.Text = (str2 & "_" & str)
    End Sub
End Class