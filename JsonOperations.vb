Imports System.Formats.Tar
Imports Newtonsoft.Json
Imports System.IO
Imports Microsoft.VisualBasic.FileIO.FileSystem
Imports System.Text.Json.JsonProperty
Imports System.Text.Json.Serialization
Imports System.Diagnostics.CodeAnalysis
Imports Word = Microsoft.Office.Interop.Word

Public Class JsonOperations
    Dim obj As Example
    Public Sub New(path)
        Dim json As String = IO.File.ReadAllText(path)
        Dim js = New JsonSerializerSettings
        js.DefaultValueHandling = DefaultValueHandling.Ignore
        obj = JsonConvert.DeserializeObject(Of Example)(json, js)
    End Sub

    Public Function GetTotal()
        Return obj.content.total.value
    End Function

    Public Function GetProducts()
        Dim ls As List(Of TableProducts) = New List(Of TableProducts)
        Dim count = 0
        For Each item In obj.content.products
            ls.Add(New TableProducts(count,
                                     item.name.value,
                                     item.price.price.value,
                                     item.price.count.value,
                                     item.price.total.value))
            count = count + 1
        Next
        Return ls
    End Function
    Public Sub AddProduct(productName As String, payMethod As String, paySubject As String, count_ As Double, price_ As Double, total_ As Double)
        obj.content.products.Add(New Product(productName, payMethod, paySubject, count_, price_, total_))
        obj.content.total.value = obj.content.total.value + total_
    End Sub

    Public Sub SaveJson(path As String)
        Dim js = New JsonSerializerSettings
        js.NullValueHandling = NullValueHandling.Ignore
        Dim jsontext = JsonConvert.SerializeObject(obj, js)
        'Dim strFile As String = "yourfile.txt"
        If (Not File.Exists(path)) Then
            Using sw As New StreamWriter(File.Open(path, FileMode.OpenOrCreate))
                sw.WriteLine(jsontext)
            End Using
        Else
            MessageBox.Show("Файл уже существует, выберите другой путь.")
        End If
    End Sub

    Public Sub SaveChanges(id As Integer, name As String, price As Double, count As Integer, total As Double)
        obj.content.products(id).name.value = name
        obj.content.products(id).price.price.value = price
        obj.content.products(id).price.count.value = count
        obj.content.products(id).price.total.value = total
    End Sub

    Public Sub SetTotalSum(sum As Double)
        obj.content.total.value = sum
    End Sub

    Public Function GetOrganizationInn()
        Return obj.organization.inn.value
    End Function
    Public Function GetOrganizationName()
        Return obj.organization.name.value
    End Function
    Public Function GetMachineNumber()
        Return obj.cashbox.machineNumber.value
    End Function
    Public Function GetMachineRegNumber()
        Return obj.cashbox.regNumber.value
    End Function
    Public Function GetDocumentNumber()
        Return obj.shift.documentNumber.value
    End Function
    Public Function GetFiscalSignature()
        Return obj.cashbox.fiscalSignature.value
    End Function
    Public Class AdditionalProperty
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class AdditionalInfo
        Public Property additionalProperty As AdditionalProperty
    End Class

    Public Class FnsUrl
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class Fns
        Public Property fnsUrl As FnsUrl
    End Class

    Public Class Operation
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class AgentPhones
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class AgentType
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class PaymentAgentPhones
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class Agent
        Public Property operation As Operation
        Public Property agentPhones As AgentPhones
        Public Property agentType As AgentType
        Public Property paymentAgentPhones As PaymentAgentPhones

    End Class

    Public Class Phone
        Public Property required As Boolean
    End Class

    Public Class Email
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class Contact
        Public Property phone As Phone
        Public Property email As Email
    End Class

    Public Class Inn
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class InnR
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class NNameR
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class NName
        Public Property required As Boolean
        Public Property value As String
    End Class

    Public Class Buyer
        Public Property contact As Contact
        Public Property inn As InnR
        Public Property name As NNameR
    End Class

    Public Class PhonesToTransfer
        Public Property required As Boolean
    End Class

    Public Class Address
        Public Property required As Boolean
    End Class

    Public Class Phones
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class SellerEmail
        Public Property value As String
        Public Property required As Boolean
    End Class
    Public Class ProductsAgent
        Private name As NNameR
        Private nameArgs = ""
        Public Property operatorPhones As OperatorPhones
        Public Property agentPhones As AgentPhones
        Public Property recipientOperatorPhones As RecepientOperatorPhones
        Public Property operation As Operation
        <JsonProperty(PropertyName:="Name")>
        Public Property Name1 As NNameR
            Set(value As NNameR)
                name = value
                nameArgs = "Name"
            End Set
            Get
                If nameArgs = "Name" Then
                    Return name
                End If
            End Get
        End Property
        <JsonProperty(PropertyName:="operatorName")>
        Public Property Name2 As NNameR
            Set(value As NNameR)
                name = value
                nameArgs = "operatorName"
            End Set
            Get
                If nameArgs = "operatorName" Then
                    Return name
                End If
            End Get
        End Property
        Public Property operatorAddress As OperatorAddress
        Public Property operatorInn As OperatorInn
        Public Property agentType As AgentType

        Public Sub New(operatorPhones_ As OperatorPhones, agentPhones_ As AgentPhones, recipientOperatorPhones_ As RecepientOperatorPhones, operation_ As Operation, name_ As NNameR, operatorAddress_ As OperatorAddress, operatorInn_ As OperatorInn, agentType_ As AgentType, isOperatorName As Boolean)
            If isOperatorName Then
                operatorPhones = operatorPhones_
                agentPhones = agentPhones_
                recipientOperatorPhones = recipientOperatorPhones_
                operation = operation_
                Name2 = name_
                operatorAddress = operatorAddress_
                operatorInn = operatorInn_
                agentType = agentType_
            Else
                operatorPhones = operatorPhones_
                agentPhones = agentPhones_
                recipientOperatorPhones = recipientOperatorPhones_
                operation = operation_
                Name1 = name_
                operatorAddress = operatorAddress_
                operatorInn = operatorInn_
                agentType = agentType_
            End If
        End Sub
    End Class
    Public Class OperatorInn
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class
    Public Class OperatorAddress
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class
    Public Class RecepientOperatorPhones
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class
    Public Class OperatorPhones
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class
    Public Class Provider
        Public Property phonesToTransfer As PhonesToTransfer
        Public Property name As NNameR
        Public Property address As Address
        Public Property inn As InnR
        Public Property phones As Phones
        Public Property sellerEmail As SellerEmail
    End Class

    Public Class CalculationType
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class Total
        Public Property value As Double
        Public Property required As Boolean
        Public Sub New(val As Double, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class CashTotal
        Public Property required As Boolean
    End Class

    Public Class Value
        Public Property value As Double
        Public Property required As Boolean
        Public Sub New(val As Double, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class CashlessTotal
        Public Property name As NName
        Public Property value As Value
    End Class

    Public Class PrePaymentTotal
        Public Property required As Boolean
    End Class

    Public Class PostPaymentTotal
        Public Property required As Boolean
    End Class

    Public Class ConsiderationTotal
        Public Property required As Boolean
    End Class

    Public Class TotalWithNds0
        Public Property required As Boolean
    End Class

    Public Class TotalWithNdsFree
        Public Property value As Double
        Public Property required As Boolean
    End Class

    Public Class PaymentMethod
        Public Property value As String
        Public Property required As Boolean
        Public Sub New(val As String, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class PaymentSubject
        Public Property value As String
        Public Property required As Boolean
        Public Sub New(val As String, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class RatePerOnePayment
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class ExciseDuty
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class Type
        Public Property value As String
        Public Property required As Boolean
        Public Sub New(val As String, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class Tax
        Public Property type As Type
        Public Property value As Value
        Public Sub New(type_ As Type, value_ As Value)
            type = type_
            value = value_
        End Sub
    End Class

    Public Class ProductTaxes
        Public Property ratePerOnePayment As RatePerOnePayment
        Public Property exciseDuty As ExciseDuty
        Public Property taxes As Tax()
        Public Sub New(ratePerOnePayment_ As RatePerOnePayment, exciseDuty_ As ExciseDuty, taxes_ As Tax())
            ratePerOnePayment = ratePerOnePayment_
            exciseDuty = exciseDuty_
            taxes = taxes_
        End Sub
    End Class

    Public Class Unit
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class Count
        Public Property value As Double
        Public Property required As Boolean
        Public Sub New(val As Double, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class PPrice
        Public Property value As Double
        Public Property required As Boolean
        Public Sub New(val As Double, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class Price
        Public Property unit As Unit
        Public Property count As Count
        Public Property price As PPrice
        Public Property total As Total
        Public Sub New(unit_ As Unit, count_ As Count, price_ As PPrice, total_ As Total)
            unit = unit_
            count = count_
            price = price_
            total = total_
        End Sub
    End Class

    Public Class Contractor
        Public Property name As NNameR
        Public Property inn As InnR
        Public Property phones As Phones
        Public Sub New(name_ As NNameR, inn_ As InnR, phones_ As Phones)
            name = name_
            inn = inn_
            phones = phones_
        End Sub
    End Class

    Public Class OriginCountryCode
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class CustomsDeclarationNumber
        Public Property required As Boolean
        Public Sub New(req As Boolean)
            required = req
        End Sub
    End Class

    Public Class ProductionInfo
        Public Property originCountryCode As OriginCountryCode
        Public Property customsDeclarationNumber As CustomsDeclarationNumber
        Public Sub New(originCountryCode_ As OriginCountryCode, customsDeclarationNumber_ As CustomsDeclarationNumber)
            originCountryCode = originCountryCode_
            customsDeclarationNumber = customsDeclarationNumber_
        End Sub
    End Class

    Public Class Additional
        Public Property additionalProperty As AdditionalProperty
        Public Sub New(additionalProperty_ As AdditionalProperty)
            additionalProperty = additionalProperty_
        End Sub
    End Class

    Public Class Product
        Public Property name As ProductName
        Public Property paymentMethod As PaymentMethod
        Public Property paymentSubject As PaymentSubject
        Public Property productTaxes As ProductTaxes
        Public Property price As Price
        Public Property agent As ProductsAgent
        Public Property contractor As Contractor
        Public Property productionInfo As ProductionInfo
        Public Property additional As Additional
        Public Sub New(productName As String, payMethod As String, paySubject As String, count_ As Double, price_ As Double, total_ As Double)
            name = New ProductName(productName, False)
            paymentMethod = New PaymentMethod(payMethod, False)
            paymentSubject = New PaymentSubject(paySubject, False)
            productTaxes = New ProductTaxes(New RatePerOnePayment(False), New ExciseDuty(False), New Tax() {New Tax(New Type("Free", False), New Value(0.0, False))})
            price = New Price(New Unit(False), New Count(count_, False), New PPrice(price_, False), New Total(total_, True))
            agent = New ProductsAgent(New OperatorPhones(False), New AgentPhones(False), New RecepientOperatorPhones(False), New Operation(False), New NNameR(False), New OperatorAddress(False), New OperatorInn(False), New AgentType(False), True)
            contractor = New Contractor(New NNameR(False), New InnR(False), New Phones(False))
            productionInfo = New ProductionInfo(New OriginCountryCode(False), New CustomsDeclarationNumber(False))
            additional = New Additional(New AdditionalProperty(False))
        End Sub
    End Class

    Public Class Content
        Public Property calculationType As CalculationType
        Public Property total As Total
        Public Property cashTotal As CashTotal
        Public Property cashlessTotal As CashlessTotal
        Public Property prePaymentTotal As PrePaymentTotal
        Public Property postPaymentTotal As PostPaymentTotal
        Public Property considerationTotal As ConsiderationTotal
        Public Property totalWithNds0 As TotalWithNds0
        Public Property totalWithNdsFree As TotalWithNdsFree
        Public Property products As List(Of Product)
    End Class

    Public Class DocumentNumber
        Public Property value As Integer
        Public Property required As Boolean
    End Class

    Public Class ShiftNumber
        Public Property value As Integer
        Public Property required As Boolean
    End Class

    Public Class Shift
        Public Property documentNumber As DocumentNumber
        Public Property shiftNumber As ShiftNumber
    End Class

    Public Class TaxationSystems
        Public Property value As String()
        Public Property required As Boolean
    End Class

    Public Class Organization
        Public Property inn As Inn
        Public Property name As OrganizationName
        Public Property taxationSystems As TaxationSystems
    End Class
    Public Class OrganizationName
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class IsInternet
        Public Property value As Boolean
        Public Property required As Boolean
    End Class

    Public Class MachineNumber
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class RegNumber
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class RetailPlace
        Public Property value As String
        Public Property required As Boolean
    End Class
    Public Class ProductName
        Public Property value As String
        Public Property required As Boolean
        Public Sub New(val As String, req As Boolean)
            value = val
            required = req
        End Sub
    End Class

    Public Class FiscalSignature
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class Cashbox
        Public Property isInternet As IsInternet
        Public Property machineNumber As MachineNumber
        Public Property regNumber As RegNumber
        Public Property address As Address
        Public Property retailPlace As RetailPlace
        Public Property fiscalSignature As FiscalSignature
    End Class

    Public Class Cashier
        Public Property name As NNameR
    End Class

    Public Class FfdVersion
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class FiscalDocumentType
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class DDateTime
        <JsonProperty(PropertyName:="value")>
        Public Property value As DateTime
        Public Property required As Boolean
    End Class

    Public Class FnSerialNumber
        Public Property value As String
        Public Property required As Boolean
    End Class

    Public Class FiscalDocumentNumber
        Public Property value As Integer
        Public Property required As Boolean
    End Class

    Public Class DocumentInfo
        Public Property ffdVersion As FfdVersion
        Public Property fiscalDocumentType As FiscalDocumentType
        Public Property dateTime As DDateTime
        Public Property fnSerialNumber As FnSerialNumber
        Public Property fiscalDocumentNumber As FiscalDocumentNumber
        Public Property canBeSentByEmail As Boolean
    End Class

    Public Class Example
        Public Property additionalInfo As AdditionalInfo
        Public Property fns As Fns
        Public Property agent As Agent
        Public Property buyer As Buyer
        Public Property provider As Provider
        Public Property taxes As Object()
        Public Property content As Content
        Public Property shift As Shift
        Public Property organization As Organization
        Public Property cashbox As Cashbox
        Public Property cashier As Cashier
        Public Property documentInfo As DocumentInfo
    End Class

    Public Class TableProducts
        Public Property id As Integer
        Public Property name As String
        Public Property price As Double
        Public Property count As Integer
        Public Property total As Double

        Public Sub New(id_ As Integer, name_ As String, price_ As Double, count_ As Integer, total_ As Double)
            id = id_
            name = name_
            price = price_
            count = count_
            total = total_
        End Sub
    End Class
End Class