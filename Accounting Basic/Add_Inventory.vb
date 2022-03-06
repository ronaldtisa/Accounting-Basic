Imports System.Data.SQLite

Public Class Add_Inventory
    Private Const ConnectionSTR As String = "Data Source=C:\Account Basic\ACCOUNTBOOK.db"
    Private Sub Add_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Company_List()
    End Sub

    Public Sub Load_Company_List()
        Using SLiteCon As SQLiteConnection = New SQLiteConnection(ConnectionSTR)
            Using SliteCom As SQLiteCommand = New SQLiteCommand("Select CompanyName From Supplier")
                SliteCom.CommandType = CommandType.Text
                Using dataadapt As SQLiteDataAdapter = New SQLiteDataAdapter(SliteCom)
                    Using dataset As New DataSet
                        Try
                            dataadapt.Fill(dataset)
                            ComboBox_Company_list.DataSource =dataset
                        Catch ex As Exception

                        End Try



                    End Using
                End Using
            End Using


        End Using
    End Sub
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
            Using SLITECOMMAND As New SQLiteCommand("Insert Into Inventory (Code, ProductName, Company_Id, Quantity, UnitPrice) Values('" + TextBox_ItemCode.Text + "', '" + TextBox_ItemName.Text + "','" + ComboBox_Company_list.Text + "','" + TextBox_Unit_Price.Text + "','" + TextBox_Total_Unit.Text + "')", SLITECONNECTION_M)
                SLITECONNECTION_M.Open()
                SLITECOMMAND.ExecuteNonQuery()
            End Using
        End Using
    End Sub


End Class