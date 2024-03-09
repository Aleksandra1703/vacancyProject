<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProduct
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        nameProduct = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        payMethod = New TextBox()
        paySubject = New TextBox()
        price = New MaskedTextBox()
        count = New MaskedTextBox()
        sum = New MaskedTextBox()
        AddProductBut = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(23, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 19)
        Label1.TabIndex = 0
        Label1.Text = "Наименование продукта"
        ' 
        ' nameProduct
        ' 
        nameProduct.Location = New Point(236, 43)
        nameProduct.Name = "nameProduct"
        nameProduct.Size = New Size(342, 23)
        nameProduct.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(68, 81)
        Label2.Name = "Label2"
        Label2.Size = New Size(143, 19)
        Label2.TabIndex = 2
        Label2.Text = "Платежный метод"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(72, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 19)
        Label3.TabIndex = 3
        Label3.Text = "Предмет платежа"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label4.Location = New Point(124, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 19)
        Label4.TabIndex = 4
        Label4.Text = "Стоимость"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label5.Location = New Point(116, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(95, 19)
        Label5.TabIndex = 5
        Label5.Text = "Количество"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(158, 234)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 19)
        Label6.TabIndex = 6
        Label6.Text = "Итого"
        ' 
        ' payMethod
        ' 
        payMethod.Location = New Point(236, 81)
        payMethod.Name = "payMethod"
        payMethod.Size = New Size(342, 23)
        payMethod.TabIndex = 7
        ' 
        ' paySubject
        ' 
        paySubject.Location = New Point(236, 117)
        paySubject.Name = "paySubject"
        paySubject.Size = New Size(342, 23)
        paySubject.TabIndex = 8
        ' 
        ' price
        ' 
        price.Location = New Point(236, 158)
        price.Name = "price"
        price.Size = New Size(342, 23)
        price.TabIndex = 9
        ' 
        ' count
        ' 
        count.Location = New Point(236, 198)
        count.Name = "count"
        count.Size = New Size(342, 23)
        count.TabIndex = 10
        ' 
        ' sum
        ' 
        sum.Location = New Point(236, 235)
        sum.Name = "sum"
        sum.Size = New Size(342, 23)
        sum.TabIndex = 11
        ' 
        ' AddProductBut
        ' 
        AddProductBut.BackColor = Color.Lime
        AddProductBut.Location = New Point(181, 279)
        AddProductBut.Name = "AddProductBut"
        AddProductBut.Size = New Size(235, 61)
        AddProductBut.TabIndex = 12
        AddProductBut.Text = "Добавить продукт"
        AddProductBut.UseVisualStyleBackColor = False
        ' 
        ' NewProduct
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(609, 352)
        Controls.Add(AddProductBut)
        Controls.Add(sum)
        Controls.Add(count)
        Controls.Add(price)
        Controls.Add(paySubject)
        Controls.Add(payMethod)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(nameProduct)
        Controls.Add(Label1)
        Name = "NewProduct"
        Text = "Добавление продукта"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents nameProduct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents payMethod As TextBox
    Friend WithEvents paySubject As TextBox
    Friend WithEvents price As MaskedTextBox
    Friend WithEvents count As MaskedTextBox
    Friend WithEvents sum As MaskedTextBox
    Friend WithEvents AddProductBut As Button
End Class
