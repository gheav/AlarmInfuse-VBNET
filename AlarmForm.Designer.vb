<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlarmForm
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
        Me.namaPasien = New System.Windows.Forms.Label()
        Me.tetesanInfus = New System.Windows.Forms.Label()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.inputPatient = New System.Windows.Forms.TextBox()
        Me.inputDrip = New System.Windows.Forms.TextBox()
        Me.titleForm = New System.Windows.Forms.Label()
        Me.inputStartAt = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputInfusCategory = New System.Windows.Forms.ComboBox()
        Me.inputEndAt = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DiscardButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'namaPasien
        '
        Me.namaPasien.AutoSize = True
        Me.namaPasien.Location = New System.Drawing.Point(14, 91)
        Me.namaPasien.Name = "namaPasien"
        Me.namaPasien.Size = New System.Drawing.Size(70, 13)
        Me.namaPasien.TabIndex = 0
        Me.namaPasien.Text = "Nama Pasien"
        '
        'tetesanInfus
        '
        Me.tetesanInfus.AutoSize = True
        Me.tetesanInfus.Location = New System.Drawing.Point(13, 132)
        Me.tetesanInfus.Name = "tetesanInfus"
        Me.tetesanInfus.Size = New System.Drawing.Size(105, 13)
        Me.tetesanInfus.TabIndex = 1
        Me.tetesanInfus.Text = "Tetesan Infus /menit"
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.saveButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight
        Me.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saveButton.Location = New System.Drawing.Point(194, 261)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 2
        Me.saveButton.Text = "Simpan"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'inputPatient
        '
        Me.inputPatient.BackColor = System.Drawing.SystemColors.HighlightText
        Me.inputPatient.Location = New System.Drawing.Point(156, 88)
        Me.inputPatient.Name = "inputPatient"
        Me.inputPatient.Size = New System.Drawing.Size(200, 20)
        Me.inputPatient.TabIndex = 3
        '
        'inputDrip
        '
        Me.inputDrip.Location = New System.Drawing.Point(156, 128)
        Me.inputDrip.Name = "inputDrip"
        Me.inputDrip.Size = New System.Drawing.Size(200, 20)
        Me.inputDrip.TabIndex = 3
        '
        'titleForm
        '
        Me.titleForm.AutoSize = True
        Me.titleForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleForm.ForeColor = System.Drawing.SystemColors.Highlight
        Me.titleForm.Location = New System.Drawing.Point(12, 9)
        Me.titleForm.Name = "titleForm"
        Me.titleForm.Size = New System.Drawing.Size(186, 25)
        Me.titleForm.TabIndex = 4
        Me.titleForm.Text = "Alarm Infus Baru"
        '
        'inputStartAt
        '
        Me.inputStartAt.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.inputStartAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.inputStartAt.Location = New System.Drawing.Point(156, 170)
        Me.inputStartAt.Name = "inputStartAt"
        Me.inputStartAt.Size = New System.Drawing.Size(200, 20)
        Me.inputStartAt.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Tanggal Jam Pemasangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Jenis Infus"
        '
        'inputInfusCategory
        '
        Me.inputInfusCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inputInfusCategory.FormattingEnabled = True
        Me.inputInfusCategory.Items.AddRange(New Object() {"Infus Makro", "Infus Mikro"})
        Me.inputInfusCategory.Location = New System.Drawing.Point(156, 51)
        Me.inputInfusCategory.Name = "inputInfusCategory"
        Me.inputInfusCategory.Size = New System.Drawing.Size(200, 21)
        Me.inputInfusCategory.TabIndex = 7
        '
        'inputEndAt
        '
        Me.inputEndAt.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.inputEndAt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.inputEndAt.Location = New System.Drawing.Point(156, 210)
        Me.inputEndAt.Name = "inputEndAt"
        Me.inputEndAt.Size = New System.Drawing.Size(200, 20)
        Me.inputEndAt.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Jam Selesai"
        '
        'DiscardButton
        '
        Me.DiscardButton.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DiscardButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DiscardButton.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.DiscardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DiscardButton.Location = New System.Drawing.Point(281, 261)
        Me.DiscardButton.Name = "DiscardButton"
        Me.DiscardButton.Size = New System.Drawing.Size(75, 23)
        Me.DiscardButton.TabIndex = 8
        Me.DiscardButton.Text = "Batal"
        Me.DiscardButton.UseVisualStyleBackColor = False
        '
        'AlarmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(385, 314)
        Me.Controls.Add(Me.DiscardButton)
        Me.Controls.Add(Me.inputInfusCategory)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.inputEndAt)
        Me.Controls.Add(Me.inputStartAt)
        Me.Controls.Add(Me.titleForm)
        Me.Controls.Add(Me.inputDrip)
        Me.Controls.Add(Me.inputPatient)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.tetesanInfus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.namaPasien)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AlarmForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buat Alarm Baru"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents namaPasien As Label
    Friend WithEvents tetesanInfus As Label
    Friend WithEvents saveButton As Button
    Friend WithEvents inputPatient As TextBox
    Friend WithEvents inputDrip As TextBox
    Friend WithEvents titleForm As Label
    Friend WithEvents inputStartAt As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputInfusCategory As ComboBox
    Friend WithEvents inputEndAt As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DiscardButton As Button
End Class
