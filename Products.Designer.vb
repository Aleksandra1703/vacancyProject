<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        SaveButton = New Button()
        AllowChangeButton = New Button()
        AddProductButton = New Button()
        ButtonBack = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(48, 79)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(844, 324)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Tahoma", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(358, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 29)
        Label1.TabIndex = 1
        Label1.Text = "Продукты в чеке"
        ' 
        ' SaveButton
        ' 
        SaveButton.BackColor = Color.Lime
        SaveButton.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        SaveButton.Location = New Point(361, 457)
        SaveButton.Name = "SaveButton"
        SaveButton.Size = New Size(197, 50)
        SaveButton.TabIndex = 2
        SaveButton.Text = "Сохранить изменения"
        SaveButton.UseVisualStyleBackColor = False
        ' 
        ' AllowChangeButton
        ' 
        AllowChangeButton.BackColor = Color.Orange
        AllowChangeButton.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        AllowChangeButton.Location = New Point(48, 457)
        AllowChangeButton.Name = "AllowChangeButton"
        AllowChangeButton.Size = New Size(187, 50)
        AllowChangeButton.TabIndex = 3
        AllowChangeButton.Text = "Изменить продукты"
        AllowChangeButton.UseVisualStyleBackColor = False
        ' 
        ' AddProductButton
        ' 
        AddProductButton.BackColor = Color.Cyan
        AddProductButton.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        AddProductButton.Location = New Point(681, 457)
        AddProductButton.Name = "AddProductButton"
        AddProductButton.Size = New Size(211, 50)
        AddProductButton.TabIndex = 4
        AddProductButton.Text = "Добавить продукт"
        AddProductButton.UseVisualStyleBackColor = False
        ' 
        ' ButtonBack
        ' 
        ButtonBack.BackColor = Color.Yellow
        ButtonBack.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        ButtonBack.Location = New Point(12, 12)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(114, 29)
        ButtonBack.TabIndex = 5
        ButtonBack.Text = "На главную"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' Products
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 546)
        Controls.Add(ButtonBack)
        Controls.Add(AddProductButton)
        Controls.Add(AllowChangeButton)
        Controls.Add(SaveButton)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "Products"
        Text = "Продукты"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents AllowChangeButton As Button
    Friend WithEvents AddProductButton As Button
    Friend WithEvents ButtonBack As Button
End Class
