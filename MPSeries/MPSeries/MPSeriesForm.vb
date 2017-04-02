Imports System.ComponentModel

Public Class MPSeries

    Private Sub b_move_Click(sender As Object, e As EventArgs) Handles b_move.Click

        Dim count As Integer = 0
        Dim moved As Boolean = False
        Dim ext As String() = Split(New String(tb_ext_list.Text.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray()), ",")
        Dim new_series As String() = IO.Directory.GetFiles(tb_new_path.Text)
        Dim series() As String = {""}

        Console.Write(tb_series_path)

        For Each to_path As String In Split(tb_series_path.Text, vbCrLf)
            series = series.Union(IO.Directory.GetDirectories(to_path)).ToArray()
        Next

        For Each file As String In new_series

            If Array.IndexOf(ext, IO.Path.GetExtension(file)) > -1 Then

                count += 1
                moved = False

                For Each directory As String In series
                    If moveFile(file, directory) Then
                        moved = True
                        Exit For
                    End If
                Next

                If Not moved Then
                    addStatus(file, "No Match found")
                End If

            End If

        Next

        If count > 0 Then
            addStatus("Done")
        Else
            addStatus("No series files found to move")
        End If

    End Sub

    Private Function moveFile(ByRef file As String, ByRef directory As String) As Boolean

        If directory = "" Then Return False

        If IO.Path.GetFileName(file).Contains(Microsoft.VisualBasic.Strings.Right(directory, Len(directory) - Len(IO.Path.GetDirectoryName(directory)) - 1)) Then

            addStatus(IO.Path.GetFileName(file), directory)

            Try
                If IO.File.Exists(directory & "\" & IO.Path.GetFileName(file)) Then IO.File.Delete(directory & "\" & IO.Path.GetFileName(file))
                IO.File.Move(file, directory & "\" & IO.Path.GetFileName(file))
            Catch ex As Exception
                addStatus(IO.Path.GetFileName(file), "Move failed!")
            End Try

            Return True
        Else
            Return False
        End If

    End Function

    Private Sub addStatus(ByRef file As String, Optional ByVal directory As String = Nothing)

        If IsNothing(directory) Then
            lb_log.Items.Add(file)
        Else
            lb_log.Items.Add(file & " -> " & directory)
        End If

        lb_log.TopIndex = lb_log.Items.Count - 1
        lb_log.Refresh()

    End Sub

    Private Sub checkButton(sender As Object, e As EventArgs) Handles tb_new_path.TextChanged, tb_series_path.TextChanged, tb_ext_list.TextChanged
        b_move.Enabled = tb_new_path.Text <> "" And tb_ext_list.Text <> "" And tb_series_path.Text <> ""
    End Sub

    Private Sub MPSeries_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tb_new_path.Text = My.Settings.new_path
        tb_series_path.Text = My.Settings.series_path
        tb_ext_list.Text = My.Settings.ext_list

        checkButton(sender, e)

        Me.Text = Me.Text & " v" & My.Application.Info.Version.ToString

    End Sub

    Private Sub MPSeries_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        My.Settings.new_path = tb_new_path.Text
        My.Settings.series_path = tb_series_path.Text
        My.Settings.ext_list = tb_ext_list.Text
        My.Settings.Save()

    End Sub

End Class