<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainApp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainApp))
        Me.DateNow = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TambahAlaramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPatient = New System.Windows.Forms.DataGridView()
        Me.PatientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InfusecategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlarmBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Alarm_infuseDataSet = New Alarm_Infus.alarm_infuseDataSet()
        Me.AlarmTableAdapter = New Alarm_Infus.alarm_infuseDataSetTableAdapters.alarmTableAdapter()
        Me.PlaySound = New System.Windows.Forms.Button()
        Me.StopSound = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimeLabel = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataPatient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Alarm_infuseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateNow
        '
        Me.DateNow.AutoSize = True
        Me.DateNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateNow.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.DateNow.Location = New System.Drawing.Point(501, 74)
        Me.DateNow.Name = "DateNow"
        Me.DateNow.Size = New System.Drawing.Size(48, 20)
        Me.DateNow.TabIndex = 1
        Me.DateNow.Text = "Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(500, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Aplikasi Alarm Infus"
        '
        'TambahAlaramToolStripMenuItem
        '
        Me.TambahAlaramToolStripMenuItem.Name = "TambahAlaramToolStripMenuItem"
        Me.TambahAlaramToolStripMenuItem.Size = New System.Drawing.Size(96, 20)
        Me.TambahAlaramToolStripMenuItem.Text = "Tambah Alarm"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahAlaramToolStripMenuItem, Me.RefreshDataToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(765, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuHeader"
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'DataPatient
        '
        Me.DataPatient.AllowUserToAddRows = False
        Me.DataPatient.AutoGenerateColumns = False
        Me.DataPatient.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataPatient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataPatient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataPatient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PatientDataGridViewTextBoxColumn, Me.EndatDataGridViewTextBoxColumn, Me.InfusecategoryDataGridViewTextBoxColumn, Me.Status})
        Me.DataPatient.DataSource = Me.AlarmBindingSource
        Me.DataPatient.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataPatient.Location = New System.Drawing.Point(14, 117)
        Me.DataPatient.Name = "DataPatient"
        Me.DataPatient.ReadOnly = True
        Me.DataPatient.Size = New System.Drawing.Size(745, 406)
        Me.DataPatient.TabIndex = 6
        '
        'PatientDataGridViewTextBoxColumn
        '
        Me.PatientDataGridViewTextBoxColumn.DataPropertyName = "patient"
        Me.PatientDataGridViewTextBoxColumn.HeaderText = "Nama Pasien"
        Me.PatientDataGridViewTextBoxColumn.Name = "PatientDataGridViewTextBoxColumn"
        Me.PatientDataGridViewTextBoxColumn.ReadOnly = True
        Me.PatientDataGridViewTextBoxColumn.Width = 300
        '
        'EndatDataGridViewTextBoxColumn
        '
        Me.EndatDataGridViewTextBoxColumn.DataPropertyName = "end_at"
        Me.EndatDataGridViewTextBoxColumn.HeaderText = "Infus Selesai"
        Me.EndatDataGridViewTextBoxColumn.Name = "EndatDataGridViewTextBoxColumn"
        Me.EndatDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndatDataGridViewTextBoxColumn.Width = 200
        '
        'InfusecategoryDataGridViewTextBoxColumn
        '
        Me.InfusecategoryDataGridViewTextBoxColumn.DataPropertyName = "infuse_category"
        Me.InfusecategoryDataGridViewTextBoxColumn.HeaderText = "Jenis Infus"
        Me.InfusecategoryDataGridViewTextBoxColumn.Name = "InfusecategoryDataGridViewTextBoxColumn"
        Me.InfusecategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        Me.Status.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'AlarmBindingSource
        '
        Me.AlarmBindingSource.DataMember = "alarm"
        Me.AlarmBindingSource.DataSource = Me.Alarm_infuseDataSet
        '
        'Alarm_infuseDataSet
        '
        Me.Alarm_infuseDataSet.DataSetName = "alarm_infuseDataSet"
        Me.Alarm_infuseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlarmTableAdapter
        '
        Me.AlarmTableAdapter.ClearBeforeFill = True
        '
        'PlaySound
        '
        Me.PlaySound.BackColor = System.Drawing.Color.LightSkyBlue
        Me.PlaySound.FlatAppearance.BorderColor = System.Drawing.Color.AliceBlue
        Me.PlaySound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlaySound.ForeColor = System.Drawing.SystemColors.InfoText
        Me.PlaySound.Location = New System.Drawing.Point(14, 32)
        Me.PlaySound.Name = "PlaySound"
        Me.PlaySound.Size = New System.Drawing.Size(109, 28)
        Me.PlaySound.TabIndex = 7
        Me.PlaySound.Text = "Play Sound"
        Me.PlaySound.UseVisualStyleBackColor = False
        '
        'StopSound
        '
        Me.StopSound.BackColor = System.Drawing.Color.Firebrick
        Me.StopSound.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.StopSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StopSound.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.StopSound.Location = New System.Drawing.Point(14, 66)
        Me.StopSound.Name = "StopSound"
        Me.StopSound.Size = New System.Drawing.Size(109, 28)
        Me.StopSound.TabIndex = 8
        Me.StopSound.Text = "Stop Sound"
        Me.StopSound.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'TimeLabel
        '
        Me.TimeLabel.AutoSize = True
        Me.TimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.TimeLabel.Location = New System.Drawing.Point(616, 74)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(47, 20)
        Me.TimeLabel.TabIndex = 1
        Me.TimeLabel.Text = "Time"
        '
        'Timer2
        '
        '
        'MainApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(765, 535)
        Me.Controls.Add(Me.StopSound)
        Me.Controls.Add(Me.PlaySound)
        Me.Controls.Add(Me.DataPatient)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TimeLabel)
        Me.Controls.Add(Me.DateNow)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Alarm Infus"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataPatient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Alarm_infuseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateNow As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TambahAlaramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataPatient As DataGridView
    Friend WithEvents Alarm_infuseDataSet As alarm_infuseDataSet
    Friend WithEvents AlarmBindingSource As BindingSource
    Friend WithEvents AlarmTableAdapter As alarm_infuseDataSetTableAdapters.alarmTableAdapter
    Friend WithEvents RefreshDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlaySound As Button
    Friend WithEvents StopSound As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TimeLabel As Label
    Friend WithEvents PatientDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InfusecategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents Timer2 As Timer
End Class
