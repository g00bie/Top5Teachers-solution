Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class frmMain
    Private Sub lstTeach_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTeach.SelectedIndexChanged
        If lstTeach.SelectedIndex = 0 Then
            lblName.Text = lstTeach.SelectedItem.ToString
            picBoxTeach.Image = My.Resources._1_
        ElseIf lstTeach.SelectedIndex = 1 Then
            lblName.Text = lstTeach.SelectedItem.ToString
            picBoxTeach.Image = My.Resources._2
        ElseIf lstTeach.SelectedIndex = 2 Then
            lblName.Text = lstTeach.SelectedItem.ToString
            picBoxTeach.Image = My.Resources._3
        ElseIf lstTeach.SelectedIndex = 3 Then
            lblName.Text = lstTeach.SelectedItem.ToString
            picBoxTeach.Image = My.Resources._4
        ElseIf lstTeach.SelectedIndex = 4 Then
            lblName.Text = lstTeach.SelectedItem.ToString
            picBoxTeach.Image = My.Resources._5

        End If

    End Sub
End Class
