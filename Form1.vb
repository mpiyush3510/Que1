Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim ad As SqlDataAdapter
    Dim dt As DataSet
    Dim dtStr As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=B:\VS_2022\Que1\Que1.mdf;Integrated Security=True"
    Dim admin As String = "Administartor Information"

    Private Sub createConnection()
        con = New SqlConnection(dtStr)
        Try
            con.Open()
            If con.State = ConnectionState.Open Then
                'MsgBox("Connected", MsgBoxStyle.Information, admin)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, admin)
        End Try
    End Sub
    Private Sub createTable()
        cmd = New SqlCommand("create table products(ProductId int primary key,ProductName varchar(50),Quantity int,Price float,ExpiryDate date)", con)
        Try
            cmd.ExecuteNonQuery()
            MsgBox("Table Created !", MsgBoxStyle.Information, admin)
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, admin)
        End Try
    End Sub

    Private Sub insertProducts()
        cmd = New SqlCommand("insert into products values(@ProductId,@ProductName,@Quantity,@Price,@ExpiryDate) ", con)
        Try
            cmd.Parameters.AddWithValue("@ProductId", Convert.ToInt32(TextBoxPid.Text))
            cmd.Parameters.AddWithValue("@ProductName", TextBoxPname.Text)
            cmd.Parameters.AddWithValue("@Quantity", Convert.ToInt32(TextBoxQuantity.Text))
            cmd.Parameters.AddWithValue("@Price", Convert.ToDouble(TextBoxPrice.Text))
            cmd.Parameters.AddWithValue("@ExpiryDate", Exdate.Value.ToShortDateString)
            cmd.ExecuteNonQuery()
            MsgBox("Product Inserted !", MsgBoxStyle.Information, admin)
            clearData()
        Catch ex As Exception
            'MsgBox("Product Already Available !", MsgBoxStyle.Critical, admin)
        End Try
    End Sub

    Private Sub showProducts()
        ad = New SqlDataAdapter("select * from products", con)
        dt = New DataSet
        ad.Fill(dt, "products")
        Try
            DataGridView1.DataSource = dt.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, admin)
        End Try
    End Sub
    Private Sub deletedProducts()
        If DataGridView1.RowCount = 0 Then
            MsgBox("Empty Data", MsgBoxStyle.Information, admin)
        End If

        If MsgBox("want to deleted ?", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical, admin) = MsgBoxResult.Cancel Then Return

        If DataGridView1.AreAllCellsSelected(0) = True Then
            cmd = New SqlCommand("delete from products", con)
            Try
                cmd.ExecuteNonQuery()
                MsgBox("All Products Deleted !", MsgBoxStyle.Information, admin)
                showProducts()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, admin)
            End Try
        End If

        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            If row.Selected Then
                cmd = New SqlCommand("Delete from products where ProductId='" & row.DataBoundItem(0).ToString & "'")
                Try
                    cmd.ExecuteNonQuery()
                    MsgBox("Data Deleted !", MsgBoxStyle.Information, admin)
                    showProducts()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Critical, admin)
                End Try
            End If
        Next
    End Sub
    Private Sub ButtonShow_Click(sender As Object, e As EventArgs) Handles ButtonShow.Click
        createConnection()
        createTable()
        isValidate()
        insertProducts()
        showProducts()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        createConnection()
        deletedProducts()
    End Sub
    Private Sub clearData()
        TextBoxPid.Clear()
        TextBoxPname.Clear()
        TextBoxQuantity.Clear()
        TextBoxPrice.Clear()
        Exdate.ResetText()
    End Sub
    Private Sub searchProduct()
        ad = New SqlDataAdapter("select * from products where ProductName Like '" & TextBoxRec.Text.Trim & "'", con)
        dt = New DataSet
        ad.Fill(dt, "products")
        Try
            DataGridView1.DataSource = dt.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Critical, admin)
        End Try
    End Sub

    Private Sub ButtonRefresh_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        createConnection()
        showProducts()
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        clearData()
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        If TextBoxRec.Text = "" Then
            MsgBox("Enter Product Name", MsgBoxStyle.Information, admin)
            Return
        End If
        If TextBoxRec.Text <> "" Then
            createConnection()
            searchProduct()
        End If
    End Sub
    Private Sub isValidate()
        If TextBoxPid.Text = "" And TextBoxPname.Text = "" And TextBoxQuantity.Text = "" And TextBoxPrice.Text = "" Then
            MsgBox("Data Empty", MsgBoxStyle.Information, admin)
            Return
        End If
        If TextBoxPid.Text = "" Then
            MsgBox("Product id Empty", MsgBoxStyle.Information, admin)
            Return
        End If
        If TextBoxPname.Text = "" Then
            MsgBox("Product Name Empty", MsgBoxStyle.Information, admin)
            Return
        End If
        If TextBoxQuantity.Text = "" Then
            MsgBox("Quantity Empty", MsgBoxStyle.Information, admin)
            Return
        End If
        If TextBoxPrice.Text = "" Then
            MsgBox("Price Empty", MsgBoxStyle.Information, admin)
            Return
        End If
    End Sub

    Private Sub delExpired_Checked(sender As Object, e As EventArgs) Handles delExpired.CheckStateChanged
        cmd = New SqlCommand("delete from products where ExpiryDate < convert(date,getDate())", con)
        Try
            cmd.ExecuteNonQuery()
            ' MsgBox("Deleted Expired Products", MsgBoxStyle.Information, admin)
            showProducts()
        Catch ex As Exception
            MsgBox("Product Not Found", MsgBoxStyle.Critical, admin)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        createConnection()
        showProducts()
    End Sub
End Class
