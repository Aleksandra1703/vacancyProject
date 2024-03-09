Public Class NewProduct
    Private Sub NewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        payMethod.ReadOnly = True
        payMethod.Text = "FinalSettlement"
        paySubject.ReadOnly = True
        paySubject.Text = "Goods"
        sum.ReadOnly = True
    End Sub

    Private Sub AddProductBut_Click(sender As Object, e As EventArgs) Handles AddProductBut.Click
        Dim name_ As String
        Dim payMethod_ As String
        Dim paySubject_ As String
        Dim count_ As Integer
        Dim price_ As Double
        Dim sum_ As Double
        If Not (Integer.TryParse(count.Text, 0) And Double.TryParse(price.Text, 0)) Then
            MessageBox.Show("Ошибка в данных, проверьте числовые значения.")
            Return
        ElseIf (nameProduct.Text = "" Or nameProduct.Text = Nothing) Then
            MessageBox.Show("Название продукта не может быть пустым!")
        Else
            name_ = nameProduct.Text
            payMethod_ = payMethod.Text
            paySubject_ = paySubject.Text
            count_ = Integer.Parse(count.Text)
            price_ = Math.Round(Double.Parse(price.Text), 2)
            sum_ = Math.Round((count_ * price_), 2)
            Form1.JsonObj.AddProduct(name_, payMethod_, paySubject_, count_, price_, sum_)
            Me.Hide()
            Products.Refresh()
            Products.Visible = True
        End If
    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        CalculateSum()
    End Sub

    Private Sub CalculateSum()
        Dim parsePrice As Double
        Dim parseCount As Integer
        If (Integer.TryParse(count.Text, 0) And Double.TryParse(price.Text, 0)) Then
            parsePrice = Double.Parse(price.Text)
            parseCount = Integer.Parse(count.Text)
            sum.Text = Math.Round((parsePrice * parseCount), 2).ToString
        End If
    End Sub

    Private Sub count_KeyPress(sender As Object, e As KeyPressEventArgs) Handles count.KeyPress
        CalculateSum()
    End Sub
End Class