<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonnelManager
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Modify = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personnel Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Personnel Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(137, 26)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(178, 20)
        Me.txtname.TabIndex = 3
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(137, 59)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(178, 20)
        Me.txtcode.TabIndex = 4
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(348, 24)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(75, 23)
        Me.Add.TabIndex = 7
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.Location = New System.Drawing.Point(348, 61)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(75, 23)
        Me.Delete.TabIndex = 8
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Modify
        '
        Me.Modify.Location = New System.Drawing.Point(348, 95)
        Me.Modify.Name = "Modify"
        Me.Modify.Size = New System.Drawing.Size(75, 23)
        Me.Modify.TabIndex = 9
        Me.Modify.Text = "Modify"
        Me.Modify.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 167)
        Me.DataGridView1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total Code"
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(137, 95)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(178, 20)
        Me.txttotal.TabIndex = 12
        '
        'PersonnelManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 309)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Modify)
        Me.Controls.Add(Me.Delete)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PersonnelManager"
        Me.Text = "Personnel Manager"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Modify As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
End Class
