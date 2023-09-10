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
        TabControl1 = New TabControl()
        TabPage_Input = New TabPage()
        LblDisplay = New Label()
        BtnExit = New Button()
        BtnClear = New Button()
        BtnPay = New Button()
        BtnCalculate = New Button()
        GroupBox3 = New GroupBox()
        RadNo = New RadioButton()
        RadYes = New RadioButton()
        GroupBox2 = New GroupBox()
        Label7 = New Label()
        CmdFruits = New ComboBox()
        CmdVeg = New ComboBox()
        CmdJunk = New ComboBox()
        CmdBeef = New ComboBox()
        CmdChicken = New ComboBox()
        ChkFruits = New CheckBox()
        ChkVeg = New CheckBox()
        ChkJunk = New CheckBox()
        ChkBeef = New CheckBox()
        ChkChicken = New CheckBox()
        GroupBox1 = New GroupBox()
        RadFemale = New RadioButton()
        RadMale = New RadioButton()
        Label6 = New Label()
        TxtEmail = New TextBox()
        Label5 = New Label()
        TxtContact = New TextBox()
        Label4 = New Label()
        TxtSurname = New TextBox()
        Label3 = New Label()
        TxtName = New TextBox()
        Label2 = New Label()
        TabPage_Output = New TabPage()
        BtnBack = New Button()
        LstDisplay = New ListBox()
        TabControl1.SuspendLayout()
        TabPage_Input.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox1.SuspendLayout()
        TabPage_Output.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage_Input)
        TabControl1.Controls.Add(TabPage_Output)
        TabControl1.Location = New Point(3, 12)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(922, 644)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage_Input
        ' 
        TabPage_Input.Controls.Add(LblDisplay)
        TabPage_Input.Controls.Add(BtnExit)
        TabPage_Input.Controls.Add(BtnClear)
        TabPage_Input.Controls.Add(BtnPay)
        TabPage_Input.Controls.Add(BtnCalculate)
        TabPage_Input.Controls.Add(GroupBox3)
        TabPage_Input.Controls.Add(GroupBox2)
        TabPage_Input.Controls.Add(GroupBox1)
        TabPage_Input.Location = New Point(4, 24)
        TabPage_Input.Name = "TabPage_Input"
        TabPage_Input.Padding = New Padding(3)
        TabPage_Input.Size = New Size(914, 616)
        TabPage_Input.TabIndex = 0
        TabPage_Input.Text = "Input"
        TabPage_Input.UseVisualStyleBackColor = True
        ' 
        ' LblDisplay
        ' 
        LblDisplay.BorderStyle = BorderStyle.Fixed3D
        LblDisplay.Font = New Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point)
        LblDisplay.Location = New Point(525, 521)
        LblDisplay.Name = "LblDisplay"
        LblDisplay.Size = New Size(334, 69)
        LblDisplay.TabIndex = 5
        ' 
        ' BtnExit
        ' 
        BtnExit.Location = New Point(778, 346)
        BtnExit.Name = "BtnExit"
        BtnExit.Size = New Size(115, 68)
        BtnExit.TabIndex = 4
        BtnExit.Text = "Exit"
        BtnExit.UseVisualStyleBackColor = True
        ' 
        ' BtnClear
        ' 
        BtnClear.Location = New Point(651, 346)
        BtnClear.Name = "BtnClear"
        BtnClear.Size = New Size(105, 67)
        BtnClear.TabIndex = 3
        BtnClear.Text = "Clear"
        BtnClear.UseVisualStyleBackColor = True
        ' 
        ' BtnPay
        ' 
        BtnPay.Location = New Point(673, 297)
        BtnPay.Name = "BtnPay"
        BtnPay.Size = New Size(166, 35)
        BtnPay.TabIndex = 2
        BtnPay.Text = "PAY"
        BtnPay.UseVisualStyleBackColor = True
        ' 
        ' BtnCalculate
        ' 
        BtnCalculate.Location = New Point(673, 242)
        BtnCalculate.Name = "BtnCalculate"
        BtnCalculate.Size = New Size(166, 34)
        BtnCalculate.TabIndex = 1
        BtnCalculate.Text = "Calculate"
        BtnCalculate.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(RadNo)
        GroupBox3.Controls.Add(RadYes)
        GroupBox3.Location = New Point(7, 499)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(470, 100)
        GroupBox3.TabIndex = 0
        GroupBox3.TabStop = False
        GroupBox3.Text = "PLASTIC BAG"
        ' 
        ' RadNo
        ' 
        RadNo.AutoSize = True
        RadNo.Location = New Point(249, 48)
        RadNo.Name = "RadNo"
        RadNo.Size = New Size(44, 19)
        RadNo.TabIndex = 1
        RadNo.TabStop = True
        RadNo.Text = "NO"
        RadNo.UseVisualStyleBackColor = True
        ' 
        ' RadYes
        ' 
        RadYes.AutoSize = True
        RadYes.Location = New Point(32, 48)
        RadYes.Name = "RadYes"
        RadYes.Size = New Size(48, 19)
        RadYes.TabIndex = 0
        RadYes.TabStop = True
        RadYes.Text = "YES"
        RadYes.UseVisualStyleBackColor = True
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Controls.Add(CmdFruits)
        GroupBox2.Controls.Add(CmdVeg)
        GroupBox2.Controls.Add(CmdJunk)
        GroupBox2.Controls.Add(CmdBeef)
        GroupBox2.Controls.Add(CmdChicken)
        GroupBox2.Controls.Add(ChkFruits)
        GroupBox2.Controls.Add(ChkVeg)
        GroupBox2.Controls.Add(ChkJunk)
        GroupBox2.Controls.Add(ChkBeef)
        GroupBox2.Controls.Add(ChkChicken)
        GroupBox2.Location = New Point(7, 223)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(622, 261)
        GroupBox2.TabIndex = 0
        GroupBox2.TabStop = False
        GroupBox2.Text = "Items"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(425, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(61, 15)
        Label7.TabIndex = 10
        Label7.Text = "Quantity"
        ' 
        ' CmdFruits
        ' 
        CmdFruits.FormattingEnabled = True
        CmdFruits.Location = New Point(426, 214)
        CmdFruits.Name = "CmdFruits"
        CmdFruits.Size = New Size(138, 23)
        CmdFruits.TabIndex = 9
        ' 
        ' CmdVeg
        ' 
        CmdVeg.FormattingEnabled = True
        CmdVeg.Location = New Point(426, 168)
        CmdVeg.Name = "CmdVeg"
        CmdVeg.Size = New Size(138, 23)
        CmdVeg.TabIndex = 8
        ' 
        ' CmdJunk
        ' 
        CmdJunk.FormattingEnabled = True
        CmdJunk.Location = New Point(426, 128)
        CmdJunk.Name = "CmdJunk"
        CmdJunk.Size = New Size(138, 23)
        CmdJunk.TabIndex = 7
        ' 
        ' CmdBeef
        ' 
        CmdBeef.FormattingEnabled = True
        CmdBeef.Location = New Point(426, 86)
        CmdBeef.Name = "CmdBeef"
        CmdBeef.Size = New Size(138, 23)
        CmdBeef.TabIndex = 6
        ' 
        ' CmdChicken
        ' 
        CmdChicken.FormattingEnabled = True
        CmdChicken.Location = New Point(426, 48)
        CmdChicken.Name = "CmdChicken"
        CmdChicken.Size = New Size(138, 23)
        CmdChicken.TabIndex = 5
        ' 
        ' ChkFruits
        ' 
        ChkFruits.AutoSize = True
        ChkFruits.Location = New Point(30, 218)
        ChkFruits.Name = "ChkFruits"
        ChkFruits.Size = New Size(61, 19)
        ChkFruits.TabIndex = 4
        ChkFruits.Text = "Fruits"
        ChkFruits.UseVisualStyleBackColor = True
        ' 
        ' ChkVeg
        ' 
        ChkVeg.AutoSize = True
        ChkVeg.Location = New Point(30, 172)
        ChkVeg.Name = "ChkVeg"
        ChkVeg.Size = New Size(88, 19)
        ChkVeg.TabIndex = 3
        ChkVeg.Text = "Vegetables"
        ChkVeg.UseVisualStyleBackColor = True
        ' 
        ' ChkJunk
        ' 
        ChkJunk.AutoSize = True
        ChkJunk.Location = New Point(30, 132)
        ChkJunk.Name = "ChkJunk"
        ChkJunk.Size = New Size(85, 19)
        ChkJunk.TabIndex = 2
        ChkJunk.Text = "Junk Food"
        ChkJunk.UseVisualStyleBackColor = True
        ' 
        ' ChkBeef
        ' 
        ChkBeef.AutoSize = True
        ChkBeef.Location = New Point(30, 90)
        ChkBeef.Name = "ChkBeef"
        ChkBeef.Size = New Size(94, 19)
        ChkBeef.TabIndex = 1
        ChkBeef.Text = "Beef Brisket"
        ChkBeef.UseVisualStyleBackColor = True
        ' 
        ' ChkChicken
        ' 
        ChkChicken.AutoSize = True
        ChkChicken.Location = New Point(30, 52)
        ChkChicken.Name = "ChkChicken"
        ChkChicken.Size = New Size(118, 19)
        ChkChicken.TabIndex = 0
        ChkChicken.Text = "Chicken Breasts"
        ChkChicken.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RadFemale)
        GroupBox1.Controls.Add(RadMale)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TxtEmail)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(TxtContact)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TxtSurname)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TxtName)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(7, 6)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(679, 211)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Customer Details"
        ' 
        ' RadFemale
        ' 
        RadFemale.AutoSize = True
        RadFemale.Location = New Point(518, 109)
        RadFemale.Name = "RadFemale"
        RadFemale.Size = New Size(67, 19)
        RadFemale.TabIndex = 10
        RadFemale.TabStop = True
        RadFemale.Text = "Female"
        RadFemale.UseVisualStyleBackColor = True
        ' 
        ' RadMale
        ' 
        RadMale.AutoSize = True
        RadMale.Location = New Point(520, 73)
        RadMale.Name = "RadMale"
        RadMale.Size = New Size(53, 19)
        RadMale.TabIndex = 9
        RadMale.TabStop = True
        RadMale.Text = "Male"
        RadMale.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(518, 42)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 8
        Label6.Text = "Gender"
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(155, 169)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(277, 21)
        TxtEmail.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 6
        Label5.Text = "Email Address"
        ' 
        ' TxtContact
        ' 
        TxtContact.Location = New Point(155, 127)
        TxtContact.Name = "TxtContact"
        TxtContact.Size = New Size(277, 21)
        TxtContact.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 4
        Label4.Text = "Contact No."
        ' 
        ' TxtSurname
        ' 
        TxtSurname.Location = New Point(155, 83)
        TxtSurname.Name = "TxtSurname"
        TxtSurname.Size = New Size(277, 21)
        TxtSurname.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 91)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 15)
        Label3.TabIndex = 2
        Label3.Text = "Surname"
        ' 
        ' TxtName
        ' 
        TxtName.Location = New Point(155, 37)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(277, 21)
        TxtName.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 45)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 15)
        Label2.TabIndex = 0
        Label2.Text = "Name/s"
        ' 
        ' TabPage_Output
        ' 
        TabPage_Output.Controls.Add(BtnBack)
        TabPage_Output.Controls.Add(LstDisplay)
        TabPage_Output.Location = New Point(4, 24)
        TabPage_Output.Name = "TabPage_Output"
        TabPage_Output.Padding = New Padding(3)
        TabPage_Output.Size = New Size(914, 616)
        TabPage_Output.TabIndex = 1
        TabPage_Output.Text = "Output"
        TabPage_Output.UseVisualStyleBackColor = True
        ' 
        ' BtnBack
        ' 
        BtnBack.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        BtnBack.Location = New Point(869, 150)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(35, 375)
        BtnBack.TabIndex = 1
        BtnBack.Text = "B A C K"
        BtnBack.UseVisualStyleBackColor = True
        ' 
        ' LstDisplay
        ' 
        LstDisplay.FormattingEnabled = True
        LstDisplay.ItemHeight = 15
        LstDisplay.Location = New Point(7, 8)
        LstDisplay.Name = "LstDisplay"
        LstDisplay.Size = New Size(854, 604)
        LstDisplay.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(926, 660)
        Controls.Add(TabControl1)
        Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name = "Form1"
        Text = "Online Classic Page"
        TabControl1.ResumeLayout(False)
        TabPage_Input.ResumeLayout(False)
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        TabPage_Output.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage_Input As TabPage
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnPay As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabPage_Output As TabPage
    Friend WithEvents LstDisplay As ListBox
    Friend WithEvents LblDisplay As Label
    Friend WithEvents RadFemale As RadioButton
    Friend WithEvents RadMale As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtContact As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtSurname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadNo As RadioButton
    Friend WithEvents RadYes As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents CmdFruits As ComboBox
    Friend WithEvents CmdVeg As ComboBox
    Friend WithEvents CmdJunk As ComboBox
    Friend WithEvents CmdBeef As ComboBox
    Friend WithEvents CmdChicken As ComboBox
    Friend WithEvents ChkFruits As CheckBox
    Friend WithEvents ChkVeg As CheckBox
    Friend WithEvents ChkJunk As CheckBox
    Friend WithEvents ChkBeef As CheckBox
    Friend WithEvents ChkChicken As CheckBox
    Friend WithEvents BtnBack As Button
End Class
