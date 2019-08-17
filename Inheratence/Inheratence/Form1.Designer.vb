<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TXBStudentID = New System.Windows.Forms.TextBox()
        Me.TBName = New System.Windows.Forms.TextBox()
        Me.lblStudentID = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.LBLAge = New System.Windows.Forms.Label()
        Me.TBAge = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(713, 415)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 23)
        Me.BtnExit.TabIndex = 8
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(632, 415)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch.TabIndex = 7
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TXBStudentID
        '
        Me.TXBStudentID.Location = New System.Drawing.Point(89, 127)
        Me.TXBStudentID.Name = "TXBStudentID"
        Me.TXBStudentID.Size = New System.Drawing.Size(100, 20)
        Me.TXBStudentID.TabIndex = 1
        '
        'TBName
        '
        Me.TBName.Location = New System.Drawing.Point(89, 194)
        Me.TBName.Name = "TBName"
        Me.TBName.Size = New System.Drawing.Size(521, 20)
        Me.TBName.TabIndex = 5
        '
        'lblStudentID
        '
        Me.lblStudentID.AutoSize = True
        Me.lblStudentID.Location = New System.Drawing.Point(89, 108)
        Me.lblStudentID.Name = "lblStudentID"
        Me.lblStudentID.Size = New System.Drawing.Size(58, 13)
        Me.lblStudentID.TabIndex = 0
        Me.lblStudentID.Text = "Student ID"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(86, 178)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Name"
        '
        'BTNAdd
        '
        Me.BTNAdd.Location = New System.Drawing.Point(551, 415)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(75, 23)
        Me.BTNAdd.TabIndex = 6
        Me.BTNAdd.Text = "Add"
        Me.BTNAdd.UseVisualStyleBackColor = True
        '
        'LBLAge
        '
        Me.LBLAge.AutoSize = True
        Me.LBLAge.Location = New System.Drawing.Point(259, 108)
        Me.LBLAge.Name = "LBLAge"
        Me.LBLAge.Size = New System.Drawing.Size(26, 13)
        Me.LBLAge.TabIndex = 2
        Me.LBLAge.Text = "Age"
        '
        'TBAge
        '
        Me.TBAge.Location = New System.Drawing.Point(259, 127)
        Me.TBAge.Name = "TBAge"
        Me.TBAge.Size = New System.Drawing.Size(100, 20)
        Me.TBAge.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBLAge)
        Me.Controls.Add(Me.TBAge)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblStudentID)
        Me.Controls.Add(Me.TBName)
        Me.Controls.Add(Me.TXBStudentID)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnExit)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TXBStudentID As TextBox
    Friend WithEvents TBName As TextBox
    Friend WithEvents lblStudentID As Label
    Friend WithEvents lblName As Label
    Friend WithEvents BTNAdd As Button
    Friend WithEvents LBLAge As Label
    Friend WithEvents TBAge As TextBox
End Class
