Imports taskPanel
Public Class Main

    Dim ArraySize As Integer = 5
    Dim taskPanel() As Panel
    Dim taskNum As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles endDate.ValueChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub taskBox_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub taskDesc_TextChanged(sender As Object, e As EventArgs) Handles taskDesc.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        ' DynamicArrayOfControls()
        taskNum = taskNum + 1
        Dim TP As taskPanel = New taskPanel()
        TP.initialise()
        taskHolder.Controls.Add(TP)
        taskAddPanel.Location = New Point(11, 75 + (taskNum * 32))

    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles startDateLabel.Click

    End Sub

    Private Sub taskHolder_Paint(sender As Object, e As PaintEventArgs) Handles taskHolder.Paint

    End Sub

    Private Sub selectTask_CheckedChanged(sender As Object, e As EventArgs) Handles selectTask.CheckedChanged
        cmdAdd.Enabled = True
    End Sub

    Private Sub selectMilestone_CheckedChanged(sender As Object, e As EventArgs) Handles selectMilestone.CheckedChanged
        cmdAdd.Enabled = True
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub DynamicArrayOfControls()
        ReDim taskPanel(ArraySize)

        For i = 1 To ArraySize
            taskNum = taskNum + 1
            MsgBox("loop" + i.ToString)
            taskPanel(i) = New Panel
            With taskPanel(i)
                .Name = "task" + taskNum.ToString
                .Text = "task" + taskNum.ToString

                .Visible = True
                .Top = 10 + (32 * i)
                .Left = 11
                .Width = 496
                .Height = 30
                .BackColor = Color.SkyBlue
            End With
            taskHolder.Controls.Add(taskPanel(i))
        Next
    End Sub


    Sub DynamicControls()

    End Sub
End Class
