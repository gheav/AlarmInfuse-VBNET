Imports System.Configuration
Imports MySql.Data.MySqlClient
Public Class MainApp

    Private Function getConnectionStrings()
        Dim setting As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("Alarm_Infus.My.MySettings.alarm_infuseConnectionString")
        Dim conString As String = ""
        If Not setting Is Nothing Then
            conString = setting.ConnectionString
        End If
        Return conString
    End Function


    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Alarm_infuseDataSet.alarm' table. You can move, or remove it, as needed.
        Me.AlarmTableAdapter.Fill(Me.Alarm_infuseDataSet.alarm)
        DateNow.Text = String.Format("{0:dd MMMM yyyy}", Now())
        Timer1.Enabled = True

        Dim getAlarm As String = "SELECT * FROM alarm"
        Using connection As MySqlConnection = New MySqlConnection(getConnectionStrings)
            Dim command As New MySqlCommand(getAlarm, connection)
            Using adapter As MySqlDataAdapter = New MySqlDataAdapter(command)
                Dim dt As DataTable = New DataTable()
                adapter.Fill(dt)
                'Dim now = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
                'If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                'For Each Row As DataRow In dt.Rows
                'Dim lst As ListViewItem
                'lst = ListPatient.Items.Add(If(Row(0) IsNot Nothing, Row("alarm_id").ToString(), ""))
                'For i As Integer = 1 To dt.Columns.Count - 1
                'lst.SubItems.Add(If(Row(i) IsNot Nothing, Row(i).ToString(), ""))
                'Next
                'Dim date1 As Date = Row(3)
                'Dim date2 As Date = now
                'Dim result As Integer = DateTime.Compare(date1, date2)
                'If result > 0 Then
                'ElseIf result = 0 Then
                'My.Computer.Audio.Play(Alarm_Infus.My.Resources.TF010, AudioPlayMode.BackgroundLoop)
                'MessageBox.Show("testere")
                'Else
                'My.Computer.Audio.Stop()
                'End If
                'Next
                'End If
            End Using
        End Using
    End Sub

    Private Sub TambahAlaramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAlaramToolStripMenuItem.Click
        AlarmForm.Show()
    End Sub

    Private Sub RefreshDataPatient_Click(sender As Object, e As EventArgs) Handles PlaySound.Click
        My.Computer.Audio.Play(Alarm_Infus.My.Resources.audio, AudioPlayMode.BackgroundLoop)
        'My.Computer.Audio.Stop()
    End Sub

    Private Sub StopSound_Click(sender As Object, e As EventArgs) Handles StopSound.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub DataPatient_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataPatient.CellFormatting

        Dim now = DateTime.Now.ToString("yyyy/MM/dd HH:mm")
        For Each dr As DataGridViewRow In DataPatient.Rows
            Dim date1 As Date = dr.Cells(1).Value
            Dim date2 As Date = now
            Dim result As Integer = DateTime.Compare(date1, date2)
            If result > 0 Then
                dr.Cells(3).Style.BackColor = Color.ForestGreen
                dr.Cells(3).Style.ForeColor = Color.White
                dr.Cells(3).Value = "Berjalan"
            ElseIf result = 0 Then
                My.Computer.Audio.Play(Alarm_Infus.My.Resources.TF010, AudioPlayMode.BackgroundLoop)
                dr.Cells(3).Style.BackColor = Color.Red
                dr.Cells(3).Style.ForeColor = Color.White
                dr.Cells(3).Value = "Infus Habis"
            Else
                My.Computer.Audio.Stop()
                dr.Cells(3).Style.BackColor = Color.SlateGray
                dr.Cells(3).Style.ForeColor = Color.White
                dr.Cells(3).Value = "Selesai"
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub DataPasienToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Me.AlarmTableAdapter.Fill(Me.Alarm_infuseDataSet.alarm)
    End Sub

End Class
