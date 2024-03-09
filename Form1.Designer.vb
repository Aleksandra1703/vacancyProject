<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ProductsView = New Button()
        Label1 = New Label()
        OrgNameBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        OrgInnBox = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        CashboxNumBox = New TextBox()
        CashboxRegNumBox = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        FiscalBox = New TextBox()
        DocNumBox = New TextBox()
        Label9 = New Label()
        SaveToFile = New Button()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        OpenFile = New Button()
        SuspendLayout()
        ' 
        ' ProductsView
        ' 
        ProductsView.Location = New Point(41, 334)
        ProductsView.Name = "ProductsView"
        ProductsView.Size = New Size(195, 50)
        ProductsView.TabIndex = 0
        ProductsView.Text = "Продукты"
        ProductsView.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label1.Location = New Point(333, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 25)
        Label1.TabIndex = 1
        Label1.Text = "Информация"
        ' 
        ' OrgNameBox
        ' 
        OrgNameBox.Location = New Point(41, 90)
        OrgNameBox.Name = "OrgNameBox"
        OrgNameBox.ReadOnly = True
        OrgNameBox.Size = New Size(236, 23)
        OrgNameBox.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.Control
        Label2.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label2.Location = New Point(102, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 19)
        Label2.TabIndex = 3
        Label2.Text = "Организация"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label3.Location = New Point(102, 69)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 18)
        Label3.TabIndex = 4
        Label3.Text = "Наименование"
        ' 
        ' OrgInnBox
        ' 
        OrgInnBox.Location = New Point(41, 149)
        OrgInnBox.Name = "OrgInnBox"
        OrgInnBox.ReadOnly = True
        OrgInnBox.Size = New Size(236, 23)
        OrgInnBox.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label4.Location = New Point(142, 128)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 18)
        Label4.TabIndex = 6
        Label4.Text = "ИНН"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.Control
        Label5.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label5.Location = New Point(607, 15)
        Label5.Name = "Label5"
        Label5.Size = New Size(49, 19)
        Label5.TabIndex = 7
        Label5.Text = "Касса"
        ' 
        ' CashboxNumBox
        ' 
        CashboxNumBox.Location = New Point(552, 90)
        CashboxNumBox.Name = "CashboxNumBox"
        CashboxNumBox.ReadOnly = True
        CashboxNumBox.Size = New Size(181, 23)
        CashboxNumBox.TabIndex = 8
        ' 
        ' CashboxRegNumBox
        ' 
        CashboxRegNumBox.Location = New Point(552, 149)
        CashboxRegNumBox.Name = "CashboxRegNumBox"
        CashboxRegNumBox.ReadOnly = True
        CashboxRegNumBox.Size = New Size(181, 23)
        CashboxRegNumBox.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label6.Location = New Point(607, 68)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 18)
        Label6.TabIndex = 10
        Label6.Text = "Номер"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label7.Location = New Point(592, 127)
        Label7.Name = "Label7"
        Label7.Size = New Size(82, 18)
        Label7.TabIndex = 11
        Label7.Text = "Рег. номер"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label8.Location = New Point(552, 190)
        Label8.Name = "Label8"
        Label8.Size = New Size(174, 18)
        Label8.TabIndex = 12
        Label8.Text = "Фискальный накопитель"
        ' 
        ' FiscalBox
        ' 
        FiscalBox.Location = New Point(552, 211)
        FiscalBox.Name = "FiscalBox"
        FiscalBox.ReadOnly = True
        FiscalBox.Size = New Size(181, 23)
        FiscalBox.TabIndex = 13
        ' 
        ' DocNumBox
        ' 
        DocNumBox.Location = New Point(321, 149)
        DocNumBox.Name = "DocNumBox"
        DocNumBox.ReadOnly = True
        DocNumBox.Size = New Size(181, 23)
        DocNumBox.TabIndex = 14
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = SystemColors.Control
        Label9.Font = New Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(204))
        Label9.Location = New Point(348, 128)
        Label9.Name = "Label9"
        Label9.Size = New Size(130, 18)
        Label9.TabIndex = 15
        Label9.Text = "Номер документа"
        ' 
        ' SaveToFile
        ' 
        SaveToFile.Location = New Point(552, 334)
        SaveToFile.Name = "SaveToFile"
        SaveToFile.Size = New Size(174, 50)
        SaveToFile.TabIndex = 16
        SaveToFile.Text = "Сохранить файл (json)"
        SaveToFile.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFile
        ' 
        OpenFile.Location = New Point(299, 334)
        OpenFile.Name = "OpenFile"
        OpenFile.Size = New Size(170, 50)
        OpenFile.TabIndex = 17
        OpenFile.Text = "Выбрать файл (json)"
        OpenFile.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(OpenFile)
        Controls.Add(SaveToFile)
        Controls.Add(Label9)
        Controls.Add(DocNumBox)
        Controls.Add(FiscalBox)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(CashboxRegNumBox)
        Controls.Add(CashboxNumBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(OrgInnBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(OrgNameBox)
        Controls.Add(Label1)
        Controls.Add(ProductsView)
        Name = "Form1"
        Text = "Информация о чеке"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ProductsView As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents OrgNameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OrgInnBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CashboxNumBox As TextBox
    Friend WithEvents CashboxRegNumBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents FiscalBox As TextBox
    Friend WithEvents DocNumBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents SaveToFile As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents OpenFile As Button

End Class
