Imports MySql.Data.MySqlClient
Public Class AlarmForm

    Dim connection As MySqlConnection

    Dim command As MySqlCommand

    Dim reader As MySqlDataReader

    Dim insertString As String

    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        connection = New MySqlConnection
        connection.ConnectionString = "server=localhost;userid=root;password=;database=alarm_infuse"
        Try
            connection.Open()
            Dim infuseCategory = inputInfusCategory.SelectedItem
            Dim patient = inputPatient.Text
            Dim startAt = inputStartAt.Value.ToString("yyyy-MM-dd HH:mm:ss")
            Dim endAt = inputEndAt.Value.ToString("yyyy-MM-dd HH:mm:ss")
            insertString = "insert into alarm (`patient`, `start_at`, `end_at`, `infuse_category`) VALUES ('" & patient & "', '" & startAt & "', '" & endAt & "', '" & infuseCategory & "')"
            command = New MySqlCommand(insertString, connection)
            reader = command.ExecuteReader
            MessageBox.Show("Sukses! Alarm Berhasil Ditambahkan")
            MainApp.AlarmTableAdapter.Fill(MainApp.Alarm_infuseDataSet.alarm)
        Catch ex As MySqlException
        Finally
            connection.Dispose()
        End Try
        Close()
    End Sub

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles DiscardButton.Click
        MainApp.AlarmTableAdapter.Fill(MainApp.Alarm_infuseDataSet.alarm)
        Close()
    End Sub


End Class