Imports Microsoft.VisualBasic
Imports System.Windows.Forms


Public Class taskPanel
    Inherits System.Windows.Forms.Panel
    Dim WithEvents deleteBtn As Button = New Button
    Dim startDate As DateTimePicker = New DateTimePicker
    Dim endDate As DateTimePicker = New DateTimePicker
    Dim taskDesc As TextBox = New TextBox

    Shared taskNum As Integer = 0
    Shared numberOfBars As Integer = 0


    Sub initialise()
        taskNum = taskNum + 1
        numberOfBars = numberOfBars + 1

        With Me
            .Visible = True
            .Top = 10 + (numberOfBars * 32)
            .Left = 11
            .Width = 496
            .Height = 30
            .BackColor = Color.SkyBlue
        End With

        With deleteBtn
            .Visible = True
            .Text = "Delete"
            .Left = 431
            .Width = 60
            .Height = 20
            .Top = 5
            .BackColor = Color.White
        End With

        With startDate
            .Visible = True
            .Left = 5
            .Width = 115
            .Height = 20
            .Top = 5
        End With

        With endDate
            .Visible = True
            .Left = 125
            .Width = 115
            .Height = 20
            .Top = 5
        End With

        With taskDesc
            .Visible = True
            .Left = 245
            .Height = 20
            .Width = 100
            .Top = 5
            .Text = "Task Description"
        End With

        Me.Controls.Add(deleteBtn)
        Me.Controls.Add(startDate)
        Me.Controls.Add(endDate)
        Me.Controls.Add(taskDesc)

    End Sub

    Private Sub delete(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Me.Dispose()
        numberOfBars = numberOfBars - 1

    End Sub
End Class
