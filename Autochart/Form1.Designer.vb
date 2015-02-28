<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.wbtPage = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.taskAddPanel = New System.Windows.Forms.Panel()
        Me.endDateLabel = New System.Windows.Forms.Label()
        Me.startDateLabel = New System.Windows.Forms.Label()
        Me.selectTask = New System.Windows.Forms.RadioButton()
        Me.taskTitle = New System.Windows.Forms.TextBox()
        Me.selectMilestone = New System.Windows.Forms.RadioButton()
        Me.startDate = New System.Windows.Forms.DateTimePicker()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.endDate = New System.Windows.Forms.DateTimePicker()
        Me.taskHolder = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.taskAddPanel.SuspendLayout()
        Me.taskHolder.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(3, 1)
        Me.MonthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar1.Location = New System.Drawing.Point(-30, -6)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ScrollChange = 1
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.ShowWeekNumbers = True
        Me.MonthCalendar1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 30)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Bar1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 39)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 342)
        Me.Panel1.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(556, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 30)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Bar1"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(357, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 30)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Bar1"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(236, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 30)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Bar1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.wbtPage)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(528, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(725, 627)
        Me.TabControl1.TabIndex = 19
        '
        'wbtPage
        '
        Me.wbtPage.Location = New System.Drawing.Point(4, 22)
        Me.wbtPage.Name = "wbtPage"
        Me.wbtPage.Padding = New System.Windows.Forms.Padding(3)
        Me.wbtPage.Size = New System.Drawing.Size(717, 601)
        Me.wbtPage.TabIndex = 1
        Me.wbtPage.Text = "WBT"
        Me.wbtPage.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(717, 601)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "PERT"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.MonthCalendar1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(717, 601)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Gantt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 31)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "AutoChart"
        '
        'taskAddPanel
        '
        Me.taskAddPanel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.taskAddPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taskAddPanel.Controls.Add(Me.endDateLabel)
        Me.taskAddPanel.Controls.Add(Me.startDateLabel)
        Me.taskAddPanel.Controls.Add(Me.selectTask)
        Me.taskAddPanel.Controls.Add(Me.taskTitle)
        Me.taskAddPanel.Controls.Add(Me.selectMilestone)
        Me.taskAddPanel.Controls.Add(Me.startDate)
        Me.taskAddPanel.Controls.Add(Me.cmdAdd)
        Me.taskAddPanel.Controls.Add(Me.endDate)
        Me.taskAddPanel.Location = New System.Drawing.Point(10, 10)
        Me.taskAddPanel.Name = "taskAddPanel"
        Me.taskAddPanel.Size = New System.Drawing.Size(496, 59)
        Me.taskAddPanel.TabIndex = 14
        '
        'endDateLabel
        '
        Me.endDateLabel.AutoSize = True
        Me.endDateLabel.Location = New System.Drawing.Point(122, 10)
        Me.endDateLabel.Name = "endDateLabel"
        Me.endDateLabel.Size = New System.Drawing.Size(52, 13)
        Me.endDateLabel.TabIndex = 15
        Me.endDateLabel.Text = "End Date"
        '
        'startDateLabel
        '
        Me.startDateLabel.AutoSize = True
        Me.startDateLabel.Location = New System.Drawing.Point(3, 13)
        Me.startDateLabel.Name = "startDateLabel"
        Me.startDateLabel.Size = New System.Drawing.Size(55, 13)
        Me.startDateLabel.TabIndex = 14
        Me.startDateLabel.Text = "Start Date"
        '
        'selectTask
        '
        Me.selectTask.AutoSize = True
        Me.selectTask.Location = New System.Drawing.Point(366, 6)
        Me.selectTask.Name = "selectTask"
        Me.selectTask.Size = New System.Drawing.Size(49, 17)
        Me.selectTask.TabIndex = 11
        Me.selectTask.TabStop = True
        Me.selectTask.Text = "Task"
        Me.selectTask.UseVisualStyleBackColor = True
        '
        'taskTitle
        '
        Me.taskTitle.Location = New System.Drawing.Point(251, 29)
        Me.taskTitle.Multiline = True
        Me.taskTitle.Name = "taskTitle"
        Me.taskTitle.Size = New System.Drawing.Size(100, 20)
        Me.taskTitle.TabIndex = 3
        Me.taskTitle.Text = "Task Description"
        '
        'selectMilestone
        '
        Me.selectMilestone.AutoSize = True
        Me.selectMilestone.Location = New System.Drawing.Point(421, 6)
        Me.selectMilestone.Name = "selectMilestone"
        Me.selectMilestone.Size = New System.Drawing.Size(70, 17)
        Me.selectMilestone.TabIndex = 12
        Me.selectMilestone.TabStop = True
        Me.selectMilestone.Text = "Milestone"
        Me.selectMilestone.UseVisualStyleBackColor = True
        '
        'startDate
        '
        Me.startDate.Location = New System.Drawing.Point(4, 29)
        Me.startDate.Name = "startDate"
        Me.startDate.Size = New System.Drawing.Size(115, 20)
        Me.startDate.TabIndex = 9
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Location = New System.Drawing.Point(421, 29)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(60, 23)
        Me.cmdAdd.TabIndex = 13
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'endDate
        '
        Me.endDate.Location = New System.Drawing.Point(125, 29)
        Me.endDate.Name = "endDate"
        Me.endDate.Size = New System.Drawing.Size(120, 20)
        Me.endDate.TabIndex = 10
        '
        'taskHolder
        '
        Me.taskHolder.AutoScroll = True
        Me.taskHolder.Controls.Add(Me.taskAddPanel)
        Me.taskHolder.Location = New System.Drawing.Point(1, 43)
        Me.taskHolder.Name = "taskHolder"
        Me.taskHolder.Size = New System.Drawing.Size(521, 593)
        Me.taskHolder.TabIndex = 18
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 639)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.taskHolder)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Main"
        Me.Text = "AutoChart"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.taskAddPanel.ResumeLayout(False)
        Me.taskAddPanel.PerformLayout()
        Me.taskHolder.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents wbtPage As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents taskAddPanel As System.Windows.Forms.Panel
    Friend WithEvents endDateLabel As System.Windows.Forms.Label
    Friend WithEvents startDateLabel As System.Windows.Forms.Label
    Friend WithEvents selectTask As System.Windows.Forms.RadioButton
    Friend WithEvents taskTitle As System.Windows.Forms.TextBox
    Friend WithEvents selectMilestone As System.Windows.Forms.RadioButton
    Friend WithEvents startDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents endDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents taskHolder As System.Windows.Forms.Panel

End Class
