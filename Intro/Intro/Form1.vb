Public Class Form1

    'Basics of Visual Studio using Windows Forms Application
    'Vhugala Galaxie

    'Declare Global Variable
    Dim dailyDate As DateTime

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ComboBox dropdown menu (number of items)

        'For Chicken Breasts
        CmdChicken.Items.Add(" Items measured in KG/s ")
        CmdChicken.Items.Add(" 1 Kg ")
        CmdChicken.Items.Add(" 2 Kg ")
        CmdChicken.Items.Add(" 5 Kg ")

        'For Beef Brisket
        CmdBeef.Items.Add(" Items measured in KG/s ")
        CmdBeef.Items.Add(" 1 Kg ")
        CmdBeef.Items.Add(" 2 Kg ")
        CmdBeef.Items.Add(" 5 Kg ")

        'For Junk Food
        CmdJunk.Items.Add(" Collecttion of Snacks ")
        CmdJunk.Items.Add(" Single Pack ")
        CmdJunk.Items.Add(" Combo Pack ")
        CmdJunk.Items.Add(" Jumbbo Combo Pack ")

        'For Vegetables
        CmdVeg.Items.Add(" Variation of Veggies ")
        CmdVeg.Items.Add(" Individual Veg ")
        CmdVeg.Items.Add(" Carrable Combo  ")
        CmdVeg.Items.Add(" Heavy Combo ")

        'For Fruits
        CmdFruits.Items.Add(" Variation Of Fruits ")
        CmdFruits.Items.Add(" Individual Fruits ")
        CmdFruits.Items.Add(" Carrable Fruits Combo ")
        CmdFruits.Items.Add(" Heavy Fruits Combo ")

    End Sub

    ' Sub procedure for Collecting Customer's Personal Details
    Private Sub PersonalDetails()

        ' Declare Variables
        Dim strName As String
        Dim strSurname As String
        Dim strContact As String
        Dim strEmail As String
        Dim chrGender As Char

        ' Assign the variables
        strName = Convert.ToString(TxtName.Text)
        strSurname = CStr(TxtSurname.Text)
        strContact = CStr(TxtContact.Text)
        strEmail = CStr(TxtEmail.Text)

        ' Selecting Customer's Gender
        If RadMale.Checked = True Then
            chrGender = RadMale.Text
        ElseIf RadFemale.Checked = True Then
            chrGender = RadFemale.Text
        End If

        'Display personal details

        'Asthetics
        LstDisplay.Items.Add(vbTab & "GALAXIE" & vbTab)
        LstDisplay.Items.Add(vbTab & dailyDate & vbTab)
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)

        'Personal Details
        LstDisplay.Items.Add(vbTab & "CUSTOMER DETAILS" & vbTab)
        LstDisplay.Items.Add("Name/s: " & vbTab & strName)
        LstDisplay.Items.Add("Surname: " & vbTab & strSurname)
        LstDisplay.Items.Add("Contact Number: " & vbTab & strContact)
        LstDisplay.Items.Add("Email Address: " & vbTab & strEmail)
        LstDisplay.Items.Add("Gender: " & vbTab & chrGender)
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)

    End Sub

    ' Fuction for Calculating and importing Items and it's quantity
    Private Function CalculateItems() As Decimal
        'declaring variables
        Dim decChicken As Decimal
        Dim decBeef As Decimal
        Dim decJunk As Decimal
        Dim decVeggie As Decimal
        Dim decFruits As Decimal
        Dim decPlasticBag As Decimal

        'declaring manipulating values
        Dim decTotalAmount As Decimal
        Dim decDiscount As Decimal
        Dim decVAT As Decimal
        Dim decVatAmount As Decimal
        Dim decFinalAmount As Decimal

        'Assigning VAT value
        decVAT = 0.15D

        'Assign prices to the items

        'For Chicken
        If ChkChicken.Checked = True Then
            decChicken = 45
        Else
            decChicken = 0
        End If

        'For Beef
        If ChkBeef.Checked = True Then
            decBeef = 65
        Else
            decBeef = 0
        End If

        'For Junk Food
        If ChkJunk.Checked = True Then
            decJunk = 50
        Else
            decJunk = 0
        End If

        'For Veggies
        If ChkVeg.Checked = True Then
            decVeggie = 40
        Else
            decVeggie = 0
        End If

        'For Fruits
        If ChkFruits.Checked = True Then
            decFruits = 60
        Else
            decFruits = 0
        End If


        'Assigning prices depending on quantity of an item

        'For Chicken
        If CmdChicken.SelectedIndex = 1 Then
            decChicken *= 1
        ElseIf CmdChicken.SelectedIndex = 2 Then
            decChicken *= 2
        ElseIf CmdChicken.SelectedIndex = 3 Then
            decChicken *= 3
        Else
            decChicken = 0
        End If

        'For Beef
        If CmdBeef.SelectedIndex = 1 Then
            decBeef *= 1
        ElseIf CmdBeef.SelectedIndex = 2 Then
            decBeef *= 2
        ElseIf CmdBeef.SelectedIndex = 3 Then
            decBeef *= 3
        Else
            decBeef = 0
        End If

        'For Junk Food
        If CmdJunk.SelectedIndex = 1 Then
            decJunk *= 1
        ElseIf CmdJunk.SelectedIndex = 2 Then
            decJunk *= 2
        ElseIf CmdJunk.SelectedIndex = 3 Then
            decJunk *= 3
        Else
            decJunk = 0
        End If

        'For Veggies
        If CmdVeg.SelectedIndex = 1 Then
            decVeggie *= 1
        ElseIf CmdVeg.SelectedIndex = 2 Then
            decVeggie *= 2
        ElseIf CmdVeg.SelectedIndex = 3 Then
            decVeggie *= 3
        Else
            decVeggie = 0
        End If

        'For Fruits
        If CmdFruits.SelectedIndex = 1 Then
            decFruits *= 1
        ElseIf CmdFruits.SelectedIndex = 2 Then
            decFruits *= 2
        ElseIf CmdFruits.SelectedIndex = 3 Then
            decFruits *= 3
        Else
            decFruits = 0
        End If

        'Price Manipulation

        'Adding the total price of all selected item
        decTotalAmount = decChicken + decBeef + decJunk + decVeggie + decFruits 'if an item is not selected it'll read it as R0.00

        'Implementing a discount for the purchase
        If decTotalAmount >= 350 And decTotalAmount <= 449 Then
            MessageBox.Show("You qualify for 10% discount", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            decDiscount = (decTotalAmount - (10% * decTotalAmount))
        ElseIf decTotalAmount >= 500 And decTotalAmount <= 600 Then
            MessageBox.Show("You qualify for 15% discount", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            decDiscount = (decTotalAmount - (15% * decTotalAmount))
        ElseIf decTotalAmount >= 601 Then
            MessageBox.Show("You qualify for 20% discount", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            decDiscount = (decTotalAmount - (20% * decTotalAmount))
        Else
            MessageBox.Show("No Discount!", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information)
            decDiscount = decTotalAmount
        End If

        'Calculating Vat amount of all items
        decVatAmount = decVAT * (decDiscount) 'VAT amount of the items selected

        'Adding the plastic Bag or not
        If RadYes.Checked = True Then
            decPlasticBag = 1.5D
        ElseIf RadNo.Checked = True Then
            decPlasticBag = 0D
        End If

        'Adding all the prices
        decFinalAmount = decDiscount + decVatAmount + decPlasticBag

        'Show the final amount
        LblDisplay.Text = decFinalAmount.ToString("C2")


        'Display Items selected and it's quantity & price
        If ChkChicken.Checked = True Then
            LstDisplay.Items.Add(CmdChicken.SelectedItem & vbTab & ChkChicken.Text & vbTab & vbTab & decChicken.ToString("C2"))
        End If
        If ChkBeef.Checked = True Then
            LstDisplay.Items.Add(CmdBeef.SelectedItem & vbTab & ChkBeef.Text & vbTab & vbTab & decBeef.ToString("C2"))
        End If
        If ChkJunk.Checked = True Then
            LstDisplay.Items.Add(CmdJunk.SelectedItem & vbTab & ChkJunk.Text & vbTab & vbTab & decJunk.ToString("C2"))
        End If
        If ChkVeg.Checked = True Then
            LstDisplay.Items.Add(CmdVeg.SelectedItem & vbTab & ChkVeg.Text & vbTab & vbTab & decVeggie.ToString("C2"))
        End If
        If ChkFruits.Checked = True Then
            LstDisplay.Items.Add(CmdFruits.SelectedItem & vbTab & ChkFruits.Text & vbTab & vbTab & decFruits.ToString("C2"))
        End If
        If RadYes.Checked = True Then
            LstDisplay.Items.Add("x1" & vbTab & "Plastic Bag" & vbTab & vbTab & decPlasticBag.ToString("C2"))
        End If
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)


        'Calculations
        LstDisplay.Items.Add("Amount before Discount: " & vbTab & decTotalAmount.ToString("C2"))
        LstDisplay.Items.Add("Discounted Amount: " & vbTab & decDiscount.ToString("C2"))
        LstDisplay.Items.Add("VAT Amount: " & vbTab & decVatAmount.ToString("C2"))
        LstDisplay.Items.Add("VAT: " & vbTab & decVAT.ToString("C2"))
        LstDisplay.Items.Add("Total Amount: " & vbTab & decFinalAmount.ToString("C2"))
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)

        Return decFinalAmount.ToString("C2")
    End Function

    'Sub Procedure to Display/Output
    Private Sub DisplayOutput()

        'Display output on the listbox at Output tab

        'Contact details
        LstDisplay.Items.Add(vbTab & "THANK YOU FOR SHOPPING WITH US" & vbTab)
        LstDisplay.Items.Add(vbTab & "CONTACT US" & vbTab)
        LstDisplay.Items.Add(vbTab & "+27159625106 / +27159625107" & vbTab)
        LstDisplay.Items.Add(vbTab & "info@galaxie.com" & vbTab)
        LstDisplay.Items.Add(vbTab & "SEE YOU SOON!" & vbTab)

    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click

        'Declare Variable
        Dim funcCall As Decimal

        'Calling Sub Procedures
        Call PersonalDetails()

        'Calling Function
        funcCall = CalculateItems()

    End Sub

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        'Declare Variable
        Dim ShowAmount As Decimal
        Dim decPay As Decimal
        Dim decChange As Decimal

        'Assign Variable
        ShowAmount = LblDisplay.Text

        'Request for payment
        If ShowAmount > 0 Then
            decPay = InputBox("Amount due is: " & vbTab & ShowAmount.ToString("C2"))
        End If
        If decPay < ShowAmount Then
            MessageBox.Show("NOT ENOUGH FUNDS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            decPay = InputBox("Enter Amount due: " & vbTab & ShowAmount.ToString("C2"))
        End If

        'Get Change
        decChange = decPay - ShowAmount

        'Display the payment process
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add("PAYMENTS")
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add("Amount Paid: " & vbTab & decPay.ToString("C2"))
        LstDisplay.Items.Add("Change: " & vbTab & decChange.ToString("C2"))
        LstDisplay.Items.Add(vbTab)
        LstDisplay.Items.Add(vbTab)
        'Calling Sub Procedures
        Call DisplayOutput()

        'Auto Switch to Tabpage 2
        TabControl1.SelectedTab = TabPage_Output

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        'Clearing the Interface

        Dim clearing As String
        clearing = MessageBox.Show("Are you sure you  want to clear the interface?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If clearing = Windows.Forms.DialogResult.Yes Then

            'Clearing Personal Details
            TxtName.Clear()
            TxtSurname.Clear()
            TxtContact.Clear()
            TxtEmail.Clear()
            If RadMale.Checked = True Then
                RadMale.Checked = False
            End If
            If RadFemale.Checked = True Then
                RadFemale.Checked = False
            End If

            'Clearing Items
            If ChkChicken.Checked = True Then
                ChkChicken.Checked = False
                CmdChicken.SelectedIndex = 0
            End If
            If ChkBeef.Checked = True Then
                ChkBeef.Checked = False
                CmdBeef.SelectedIndex = 0
            End If
            If ChkJunk.Checked = True Then
                ChkJunk.Checked = False
                CmdJunk.SelectedIndex = 0
            End If
            If ChkVeg.Checked = True Then
                ChkVeg.Checked = False
                CmdVeg.SelectedIndex = 0
            End If
            If ChkFruits.Checked = True Then
                ChkFruits.Checked = False
                CmdFruits.SelectedIndex = 0
            End If

            'Clearing plastics option
            If RadYes.Checked = True Then
                RadYes.Checked = False
            End If
            If RadNo.Checked = True Then
                RadNo.Checked = False
            End If

            LblDisplay.Text = ""
        Else
            Me.Focus()
        End If

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        'Exiting the application

        Dim close As Integer = 0
        close = MessageBox.Show("Are you sure you  want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)

        If close = Windows.Forms.DialogResult.Yes Then
            Application.Exit() 'same as me.close()
        Else
            Me.Focus()
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click

        'Auto tab switch back to tabpage 1
        TabControl1.SelectedIndex = 0

    End Sub
End Class
