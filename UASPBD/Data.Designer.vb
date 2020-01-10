<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormData))
        Me.GroupBoxBtn = New System.Windows.Forms.GroupBox()
        Me.CheckBoxDelete = New System.Windows.Forms.CheckBox()
        Me.CheckBoxUpdate = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAdd = New System.Windows.Forms.CheckBox()
        Me.TextBoxNoHp = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxAlamat = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupBoxDataAccount = New System.Windows.Forms.GroupBox()
        Me.DataGridViewData = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBtn.SuspendLayout()
        Me.GroupBoxDataAccount.SuspendLayout()
        CType(Me.DataGridViewData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBtn
        '
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxDelete)
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxUpdate)
        Me.GroupBoxBtn.Controls.Add(Me.CheckBoxAdd)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxNoHp)
        Me.GroupBoxBtn.Controls.Add(Me.Label3)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxAlamat)
        Me.GroupBoxBtn.Controls.Add(Me.Label2)
        Me.GroupBoxBtn.Controls.Add(Me.TextBoxNama)
        Me.GroupBoxBtn.Controls.Add(Me.Label1)
        Me.GroupBoxBtn.Controls.Add(Me.ButtonSave)
        Me.GroupBoxBtn.Controls.Add(Me.ButtonClear)
        Me.GroupBoxBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxBtn.Location = New System.Drawing.Point(15, 28)
        Me.GroupBoxBtn.Name = "GroupBoxBtn"
        Me.GroupBoxBtn.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxBtn.Size = New System.Drawing.Size(352, 167)
        Me.GroupBoxBtn.TabIndex = 3
        Me.GroupBoxBtn.TabStop = False
        '
        'CheckBoxDelete
        '
        Me.CheckBoxDelete.AutoSize = True
        Me.CheckBoxDelete.Location = New System.Drawing.Point(186, 99)
        Me.CheckBoxDelete.Name = "CheckBoxDelete"
        Me.CheckBoxDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxDelete.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxDelete.TabIndex = 12
        Me.CheckBoxDelete.Text = "Delete"
        Me.CheckBoxDelete.UseVisualStyleBackColor = True
        '
        'CheckBoxUpdate
        '
        Me.CheckBoxUpdate.AutoSize = True
        Me.CheckBoxUpdate.Location = New System.Drawing.Point(119, 99)
        Me.CheckBoxUpdate.Name = "CheckBoxUpdate"
        Me.CheckBoxUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxUpdate.Size = New System.Drawing.Size(61, 17)
        Me.CheckBoxUpdate.TabIndex = 8
        Me.CheckBoxUpdate.Text = "Update"
        Me.CheckBoxUpdate.UseVisualStyleBackColor = True
        '
        'CheckBoxAdd
        '
        Me.CheckBoxAdd.AutoSize = True
        Me.CheckBoxAdd.Location = New System.Drawing.Point(68, 99)
        Me.CheckBoxAdd.Name = "CheckBoxAdd"
        Me.CheckBoxAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBoxAdd.Size = New System.Drawing.Size(45, 17)
        Me.CheckBoxAdd.TabIndex = 7
        Me.CheckBoxAdd.Text = "Add"
        Me.CheckBoxAdd.UseVisualStyleBackColor = True
        '
        'TextBoxNoHp
        '
        Me.TextBoxNoHp.Location = New System.Drawing.Point(68, 73)
        Me.TextBoxNoHp.Name = "TextBoxNoHp"
        Me.TextBoxNoHp.Size = New System.Drawing.Size(175, 20)
        Me.TextBoxNoHp.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label3.Size = New System.Drawing.Size(43, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No.Hp"
        '
        'TextBoxAlamat
        '
        Me.TextBoxAlamat.Location = New System.Drawing.Point(69, 47)
        Me.TextBoxAlamat.Name = "TextBoxAlamat"
        Me.TextBoxAlamat.Size = New System.Drawing.Size(265, 20)
        Me.TextBoxAlamat.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label2.Size = New System.Drawing.Size(44, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Alamat"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(68, 21)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(206, 20)
        Me.TextBoxNama.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nama"
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(68, 122)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(75, 25)
        Me.ButtonSave.TabIndex = 9
        Me.ButtonSave.Text = "Yes"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(259, 122)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(75, 25)
        Me.ButtonClear.TabIndex = 11
        Me.ButtonClear.Text = "Refresh"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'GroupBoxDataAccount
        '
        Me.GroupBoxDataAccount.Controls.Add(Me.DataGridViewData)
        Me.GroupBoxDataAccount.Controls.Add(Me.GroupBoxBtn)
        Me.GroupBoxDataAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxDataAccount.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxDataAccount.Name = "GroupBoxDataAccount"
        Me.GroupBoxDataAccount.Padding = New System.Windows.Forms.Padding(15)
        Me.GroupBoxDataAccount.Size = New System.Drawing.Size(382, 381)
        Me.GroupBoxDataAccount.TabIndex = 3
        Me.GroupBoxDataAccount.TabStop = False
        '
        'DataGridViewData
        '
        Me.DataGridViewData.AllowUserToAddRows = False
        Me.DataGridViewData.AllowUserToDeleteRows = False
        Me.DataGridViewData.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewData.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridViewData.GridColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewData.Location = New System.Drawing.Point(15, 195)
        Me.DataGridViewData.Name = "DataGridViewData"
        Me.DataGridViewData.ReadOnly = True
        Me.DataGridViewData.Size = New System.Drawing.Size(352, 154)
        Me.DataGridViewData.TabIndex = 12
        '
        'FormData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 381)
        Me.Controls.Add(Me.GroupBoxDataAccount)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormData"
        Me.Text = "Data"
        Me.GroupBoxBtn.ResumeLayout(False)
        Me.GroupBoxBtn.PerformLayout()
        Me.GroupBoxDataAccount.ResumeLayout(False)
        CType(Me.DataGridViewData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxBtn As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxUpdate As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAdd As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxNoHp As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonClear As System.Windows.Forms.Button
    Friend WithEvents GroupBoxDataAccount As System.Windows.Forms.GroupBox
    Public WithEvents DataGridViewData As System.Windows.Forms.DataGridView
    Friend WithEvents CheckBoxDelete As System.Windows.Forms.CheckBox

End Class
