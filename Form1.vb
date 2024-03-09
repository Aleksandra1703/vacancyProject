Imports Newtonsoft.Json
Imports System.ComponentModel
Imports System.IO
Imports System.Text.Json.Nodes
Public Class Form1
    Public JsonObj As JsonOperations
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SaveFileDialog1.Filter = "Json files (*.json)|*.json"
        OpenFileDialog1.Filter = "Json files (*.json)|*.json"
        ProductsView.Visible = False
        SaveToFile.Visible = False
    End Sub
    Private Sub ProductsView_Click(sender As Object, e As EventArgs) Handles ProductsView.Click
        Me.Visible = False
        Products.ShowDialog()
    End Sub

    Private Sub GetInfo()
        OrgInnBox.Text = JsonObj.GetOrganizationInn
        OrgNameBox.Text = JsonObj.GetOrganizationName
        CashboxNumBox.Text = JsonObj.GetMachineNumber
        CashboxRegNumBox.Text = JsonObj.GetMachineRegNumber
        DocNumBox.Text = JsonObj.GetDocumentNumber
        FiscalBox.Text = JsonObj.GetFiscalSignature
    End Sub

    Private Sub SaveToFile_Click(sender As Object, e As EventArgs) Handles SaveToFile.Click
        If (SaveFileDialog1.ShowDialog() = DialogResult.Cancel) Then
            Return
        End If
        Dim filename As String = ""
        filename = SaveFileDialog1.FileName
        If filename <> "" Then
            JsonObj.SaveJson(filename)
        End If
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        If (OpenFileDialog1.ShowDialog() = DialogResult.Cancel) Then
            Return
        End If
        Dim filename As String = ""
        filename = OpenFileDialog1.FileName
        If filename <> "" Then
            Try
                JsonObj = New JsonOperations(filename)
                JsonObj.GetProducts()
                GetInfo()
                ProductsView.Visible = True
                SaveToFile.Visible = True
                OpenFile.Visible = False
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        End If
    End Sub
End Class
