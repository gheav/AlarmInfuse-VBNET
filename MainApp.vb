Public Class MainApp
    Shared Sub Main()
        Dim MainApp As Form = New MainApp
        Application.Run(MainApp)
    End Sub
    Private Sub MainApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Alarm_infuseDataSet.alarm' table. You can move, or remove it, as needed.
        Me.AlarmTableAdapter.Fill(Me.Alarm_infuseDataSet.alarm)
        DateNow.Text = String.Format("{0:dd MMMM yyyy}", Now())
        Timer1.Start()
    End Sub

    Private Sub TambahAlaramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahAlaramToolStripMenuItem.Click
        AlarmForm.Show()
    End Sub

    Private Sub PlaySound_Click(sender As Object, e As EventArgs) Handles PlaySound.Click
        My.Computer.Audio.Play("C:\TF010.wav", AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub StopSound_Click(sender As Object, e As EventArgs) Handles StopSound.Click
        My.Computer.Audio.Stop()
    End Sub

    Dim dt As New DataTable


    Private Sub DataPatient_DoWork(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles DataPatient.DoWork
        Dim now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")
        For Each dr As DataGridViewRow In DataPatient.Rows
            Dim date1 As Date = dr.Cells(1).Value
            Dim date2 As Date = now
            Dim result As Integer = DateTime.Compare(date1, date2)

            If result > 0 Then
                dr.Cells(3).Style.BackColor = Color.ForestGreen
                dr.Cells(3).Style.ForeColor = Color.White
                dr.Cells(3).Value = "Berjalan"
            ElseIf result = 0 Then
                My.Computer.Audio.Play("C:\TF010.wav", AudioPlayMode.BackgroundLoop)
            Else
                dr.Cells(3).Style.BackColor = Color.Red
                dr.Cells(3).Style.ForeColor = Color.White
                dr.Cells(3).Value = "Selesai"
            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TimeLabel.Text = TimeOfDay.ToString("h:mm:ss tt")
    End Sub

End Class
