Imports Microsoft.VisualBasic
Imports System.Windows.Forms


Public Class wbtSquare
    Inherits System.Windows.Forms.Panel
    Shared numberOfTasks As Integer = 0
    Dim wbtTitle As TextBox = New TextBox

    Sub initialise()

        With Me
            .Visible = True
            .Top = 30 + (55 * numberOfTasks)
            .Left = (Main.wbtPage.Width / 2) - (50)
            .Width = 100
            .Height = 50
            .BackColor = Color.SkyBlue

            With wbtTitle
                .Visible = True
                .Left = 0
                .Height = 20
                .Width = 90
                .Top = 0
                .Text = Main.taskTitle.Text
            End With

        End With
        Me.Controls.Add(wbtTitle)
        numberOfTasks = numberOfTasks + 1
    End Sub

End Class
