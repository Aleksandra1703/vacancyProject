Imports System.Linq.Expressions

Public Class Products
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Form1.JsonObj.GetProducts()
        FormatTable()
    End Sub

    Public Sub Refresh()
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Form1.JsonObj.GetProducts()
        FormatTable()
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim sum As Double = 0
        For i As Integer = 0 To DataGridView1.RowCount - 1
            Dim id As Integer = DataGridView1.Rows(i).Cells("id").Value
            Dim name As String = DataGridView1.Rows(i).Cells("name").Value
            Dim price As Double = DataGridView1.Rows(i).Cells("price").Value
            Dim count As Integer = DataGridView1.Rows(i).Cells("count").Value
            Dim total As Double = DataGridView1.Rows(i).Cells("total").Value
            sum = sum + total
            Form1.JsonObj.SaveChanges(id, name, price, count, total)
        Next
        Form1.JsonObj.SetTotalSum(sum)
        DataGridView1.DataSource = Nothing
        DataGridView1.DataSource = Form1.JsonObj.GetProducts()
        FormatTable()
    End Sub

    Private Sub FormatTable()
        DataGridView1.Columns("id").Visible = False
        DataGridView1.Columns("name").HeaderText = "Наименование"
        DataGridView1.Columns("name").Width = 350
        DataGridView1.Columns("price").HeaderText = "Цена"
        DataGridView1.Columns("price").Width = 150
        DataGridView1.Columns("count").HeaderText = "Количество"
        DataGridView1.Columns("count").Width = 150
        DataGridView1.Columns("total").HeaderText = "Итого"
        DataGridView1.Columns("total").Width = 150
        DataGridView1.ReadOnly = True
        SaveButton.Enabled = False
        AllowChangeButton.Enabled = True
    End Sub

    Private Sub AllowChangeButton_Click(sender As Object, e As EventArgs) Handles AllowChangeButton.Click
        DataGridView1.ReadOnly = False
        AllowChangeButton.Enabled = False
        SaveButton.Enabled = True
    End Sub

    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        MessageBox.Show("Проверьте корректность введенных данных")
    End Sub

    Private Sub DataGridView1_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellValueChanged
        If (DataGridView1.CurrentRow IsNot Nothing) Then
            Dim index = DataGridView1.CurrentCell.RowIndex
            DataGridView1.Rows(index).Cells("total").Value = DataGridView1.Rows(index).Cells("price").Value * DataGridView1.Rows(index).Cells("count").Value
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Me.Hide()
        Form1.Visible = True
    End Sub

    Private Sub AddProductButton_Click(sender As Object, e As EventArgs) Handles AddProductButton.Click
        Me.Hide()
        NewProduct.Visible = True
    End Sub
End Class