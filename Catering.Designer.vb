<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catering
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSubheader = New System.Windows.Forms.Label()
        Me.radCheese = New System.Windows.Forms.RadioButton()
        Me.radPinwheel = New System.Windows.Forms.RadioButton()
        Me.boxFood = New System.Windows.Forms.GroupBox()
        Me.radFruit = New System.Windows.Forms.RadioButton()
        Me.radSausage = New System.Windows.Forms.RadioButton()
        Me.radVeggie = New System.Windows.Forms.RadioButton()
        Me.boxPayment = New System.Windows.Forms.GroupBox()
        Me.radPickup = New System.Windows.Forms.RadioButton()
        Me.radPrePay = New System.Windows.Forms.RadioButton()
        Me.lblLoyaltyPoints = New System.Windows.Forms.Label()
        Me.txtLoyaltyPoints = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblPleasePay = New System.Windows.Forms.Label()
        Me.lblPaymentOutput = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.boxFood.SuspendLayout()
        Me.boxPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Catering.My.Resources.Resources.platter
        Me.PictureBox1.Location = New System.Drawing.Point(381, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(434, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(88, 36)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(160, 43)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Catering"
        '
        'lblSubheader
        '
        Me.lblSubheader.AutoSize = True
        Me.lblSubheader.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubheader.Location = New System.Drawing.Point(91, 88)
        Me.lblSubheader.Name = "lblSubheader"
        Me.lblSubheader.Size = New System.Drawing.Size(139, 29)
        Me.lblSubheader.TabIndex = 2
        Me.lblSubheader.Text = "Star Market"
        '
        'radCheese
        '
        Me.radCheese.AutoSize = True
        Me.radCheese.Location = New System.Drawing.Point(41, 19)
        Me.radCheese.Name = "radCheese"
        Me.radCheese.Size = New System.Drawing.Size(140, 17)
        Me.radCheese.TabIndex = 3
        Me.radCheese.TabStop = True
        Me.radCheese.Text = "Gourmet Cheese $49.99"
        Me.radCheese.UseVisualStyleBackColor = True
        '
        'radPinwheel
        '
        Me.radPinwheel.AutoSize = True
        Me.radPinwheel.Location = New System.Drawing.Point(41, 42)
        Me.radPinwheel.Name = "radPinwheel"
        Me.radPinwheel.Size = New System.Drawing.Size(138, 17)
        Me.radPinwheel.TabIndex = 4
        Me.radPinwheel.TabStop = True
        Me.radPinwheel.Text = "Pinwheel Wraps $59.99"
        Me.radPinwheel.UseVisualStyleBackColor = True
        '
        'boxFood
        '
        Me.boxFood.BackColor = System.Drawing.Color.SeaShell
        Me.boxFood.Controls.Add(Me.radFruit)
        Me.boxFood.Controls.Add(Me.radSausage)
        Me.boxFood.Controls.Add(Me.radVeggie)
        Me.boxFood.Controls.Add(Me.radPinwheel)
        Me.boxFood.Controls.Add(Me.radCheese)
        Me.boxFood.Location = New System.Drawing.Point(12, 133)
        Me.boxFood.Name = "boxFood"
        Me.boxFood.Size = New System.Drawing.Size(359, 140)
        Me.boxFood.TabIndex = 5
        Me.boxFood.TabStop = False
        Me.boxFood.Text = "GroupBox1"
        '
        'radFruit
        '
        Me.radFruit.AutoSize = True
        Me.radFruit.Location = New System.Drawing.Point(41, 111)
        Me.radFruit.Name = "radFruit"
        Me.radFruit.Size = New System.Drawing.Size(114, 17)
        Me.radFruit.TabIndex = 7
        Me.radFruit.TabStop = True
        Me.radFruit.Text = "Fruit Platter $29.99"
        Me.radFruit.UseVisualStyleBackColor = True
        '
        'radSausage
        '
        Me.radSausage.AutoSize = True
        Me.radSausage.Location = New System.Drawing.Point(41, 88)
        Me.radSausage.Name = "radSausage"
        Me.radSausage.Size = New System.Drawing.Size(163, 17)
        Me.radSausage.TabIndex = 6
        Me.radSausage.TabStop = True
        Me.radSausage.Text = "Sausage and Cheese $49.99"
        Me.radSausage.UseVisualStyleBackColor = True
        '
        'radVeggie
        '
        Me.radVeggie.AutoSize = True
        Me.radVeggie.Location = New System.Drawing.Point(41, 65)
        Me.radVeggie.Name = "radVeggie"
        Me.radVeggie.Size = New System.Drawing.Size(127, 17)
        Me.radVeggie.TabIndex = 5
        Me.radVeggie.TabStop = True
        Me.radVeggie.Text = "Veggie Platter $29.99"
        Me.radVeggie.UseVisualStyleBackColor = True
        '
        'boxPayment
        '
        Me.boxPayment.BackColor = System.Drawing.Color.SeaShell
        Me.boxPayment.Controls.Add(Me.radPickup)
        Me.boxPayment.Controls.Add(Me.radPrePay)
        Me.boxPayment.Location = New System.Drawing.Point(48, 296)
        Me.boxPayment.Name = "boxPayment"
        Me.boxPayment.Size = New System.Drawing.Size(168, 81)
        Me.boxPayment.TabIndex = 6
        Me.boxPayment.TabStop = False
        Me.boxPayment.Text = "GroupBox2"
        '
        'radPickup
        '
        Me.radPickup.AutoSize = True
        Me.radPickup.Location = New System.Drawing.Point(22, 42)
        Me.radPickup.Name = "radPickup"
        Me.radPickup.Size = New System.Drawing.Size(106, 17)
        Me.radPickup.TabIndex = 1
        Me.radPickup.TabStop = True
        Me.radPickup.Text = "Pay upon Pickup"
        Me.radPickup.UseVisualStyleBackColor = True
        '
        'radPrePay
        '
        Me.radPrePay.AutoSize = True
        Me.radPrePay.Location = New System.Drawing.Point(22, 19)
        Me.radPrePay.Name = "radPrePay"
        Me.radPrePay.Size = New System.Drawing.Size(62, 17)
        Me.radPrePay.TabIndex = 0
        Me.radPrePay.TabStop = True
        Me.radPrePay.Text = "Pre-Pay"
        Me.radPrePay.UseVisualStyleBackColor = True
        '
        'lblLoyaltyPoints
        '
        Me.lblLoyaltyPoints.AutoSize = True
        Me.lblLoyaltyPoints.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoyaltyPoints.Location = New System.Drawing.Point(407, 321)
        Me.lblLoyaltyPoints.Name = "lblLoyaltyPoints"
        Me.lblLoyaltyPoints.Size = New System.Drawing.Size(172, 29)
        Me.lblLoyaltyPoints.TabIndex = 7
        Me.lblLoyaltyPoints.Text = "Loyalty Points:"
        '
        'txtLoyaltyPoints
        '
        Me.txtLoyaltyPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLoyaltyPoints.Location = New System.Drawing.Point(601, 322)
        Me.txtLoyaltyPoints.Name = "txtLoyaltyPoints"
        Me.txtLoyaltyPoints.Size = New System.Drawing.Size(67, 26)
        Me.txtLoyaltyPoints.TabIndex = 8
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.PeachPuff
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(412, 390)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(142, 47)
        Me.btnCalculate.TabIndex = 9
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.PeachPuff
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(601, 390)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(142, 47)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblPleasePay
        '
        Me.lblPleasePay.AutoSize = True
        Me.lblPleasePay.Font = New System.Drawing.Font("Georgia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPleasePay.Location = New System.Drawing.Point(65, 466)
        Me.lblPleasePay.Name = "lblPleasePay"
        Me.lblPleasePay.Size = New System.Drawing.Size(134, 29)
        Me.lblPleasePay.TabIndex = 11
        Me.lblPleasePay.Text = "Please Pay:"
        '
        'lblPaymentOutput
        '
        Me.lblPaymentOutput.AutoSize = True
        Me.lblPaymentOutput.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaymentOutput.Location = New System.Drawing.Point(205, 474)
        Me.lblPaymentOutput.Name = "lblPaymentOutput"
        Me.lblPaymentOutput.Size = New System.Drawing.Size(0, 18)
        Me.lblPaymentOutput.TabIndex = 12
        '
        'Catering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PeachPuff
        Me.ClientSize = New System.Drawing.Size(827, 575)
        Me.Controls.Add(Me.lblPaymentOutput)
        Me.Controls.Add(Me.lblPleasePay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtLoyaltyPoints)
        Me.Controls.Add(Me.lblLoyaltyPoints)
        Me.Controls.Add(Me.boxPayment)
        Me.Controls.Add(Me.boxFood)
        Me.Controls.Add(Me.lblSubheader)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Catering"
        Me.Text = "Catering"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.boxFood.ResumeLayout(False)
        Me.boxFood.PerformLayout()
        Me.boxPayment.ResumeLayout(False)
        Me.boxPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSubheader As Label
    Friend WithEvents radCheese As RadioButton
    Friend WithEvents radPinwheel As RadioButton
    Friend WithEvents boxFood As GroupBox
    Friend WithEvents boxPayment As GroupBox
    Friend WithEvents radPrePay As RadioButton
    Friend WithEvents radFruit As RadioButton
    Friend WithEvents radSausage As RadioButton
    Friend WithEvents radVeggie As RadioButton
    Friend WithEvents radPickup As RadioButton
    Friend WithEvents lblLoyaltyPoints As Label
    Friend WithEvents txtLoyaltyPoints As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPleasePay As Label
    Friend WithEvents lblPaymentOutput As Label
End Class
