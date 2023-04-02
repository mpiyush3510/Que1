<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        GroupBox1 = New GroupBox()
        delExpired = New CheckBox()
        ButtonSearch = New Button()
        TextBoxRec = New TextBox()
        ButtonClear = New Button()
        ButtonDelete = New Button()
        ButtonRefresh = New Button()
        Exdate = New DateTimePicker()
        TextBoxPname = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBoxQuantity = New TextBox()
        Label4 = New Label()
        TextBoxPrice = New TextBox()
        Label3 = New Label()
        ButtonShow = New Button()
        TextBoxPid = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Cornsilk
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(58, 614)
        DataGridView1.Margin = New Padding(4, 2, 4, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 82
        DataGridView1.RowTemplate.Height = 41
        DataGridView1.Size = New Size(1313, 301)
        DataGridView1.TabIndex = 0
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Cornsilk
        GroupBox1.Controls.Add(delExpired)
        GroupBox1.Controls.Add(ButtonSearch)
        GroupBox1.Controls.Add(TextBoxRec)
        GroupBox1.Controls.Add(ButtonClear)
        GroupBox1.Controls.Add(ButtonDelete)
        GroupBox1.Controls.Add(ButtonRefresh)
        GroupBox1.Controls.Add(Exdate)
        GroupBox1.Controls.Add(TextBoxPname)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBoxQuantity)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBoxPrice)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(ButtonShow)
        GroupBox1.Controls.Add(TextBoxPid)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(58, 34)
        GroupBox1.Margin = New Padding(4, 2, 4, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4, 2, 4, 2)
        GroupBox1.Size = New Size(1313, 557)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Mahisagar General Store"
        ' 
        ' delExpired
        ' 
        delExpired.AutoSize = True
        delExpired.Location = New Point(539, 361)
        delExpired.Margin = New Padding(4, 2, 4, 2)
        delExpired.Name = "delExpired"
        delExpired.Size = New Size(215, 36)
        delExpired.TabIndex = 18
        delExpired.Text = "Deleted Expired"
        delExpired.UseVisualStyleBackColor = True
        ' 
        ' ButtonSearch
        ' 
        ButtonSearch.Location = New Point(576, 474)
        ButtonSearch.Margin = New Padding(4, 2, 4, 2)
        ButtonSearch.Name = "ButtonSearch"
        ButtonSearch.Size = New Size(150, 47)
        ButtonSearch.TabIndex = 17
        ButtonSearch.Text = "Search"
        ButtonSearch.UseVisualStyleBackColor = True
        ' 
        ' TextBoxRec
        ' 
        TextBoxRec.Location = New Point(449, 416)
        TextBoxRec.Margin = New Padding(4, 2, 4, 2)
        TextBoxRec.Name = "TextBoxRec"
        TextBoxRec.Size = New Size(400, 39)
        TextBoxRec.TabIndex = 16
        ' 
        ' ButtonClear
        ' 
        ButtonClear.Location = New Point(891, 474)
        ButtonClear.Margin = New Padding(4, 2, 4, 2)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(150, 47)
        ButtonClear.TabIndex = 15
        ButtonClear.Text = "Clear"
        ButtonClear.UseVisualStyleBackColor = True
        ' 
        ' ButtonDelete
        ' 
        ButtonDelete.Location = New Point(891, 373)
        ButtonDelete.Margin = New Padding(4, 2, 4, 2)
        ButtonDelete.Name = "ButtonDelete"
        ButtonDelete.Size = New Size(150, 47)
        ButtonDelete.TabIndex = 14
        ButtonDelete.Text = "Delete"
        ButtonDelete.UseVisualStyleBackColor = True
        ' 
        ' ButtonRefresh
        ' 
        ButtonRefresh.Location = New Point(254, 474)
        ButtonRefresh.Margin = New Padding(4, 2, 4, 2)
        ButtonRefresh.Name = "ButtonRefresh"
        ButtonRefresh.Size = New Size(150, 47)
        ButtonRefresh.TabIndex = 13
        ButtonRefresh.Text = "Refresh"
        ButtonRefresh.UseVisualStyleBackColor = True
        ' 
        ' Exdate
        ' 
        Exdate.Location = New Point(786, 256)
        Exdate.Margin = New Padding(4, 2, 4, 2)
        Exdate.Name = "Exdate"
        Exdate.Size = New Size(400, 39)
        Exdate.TabIndex = 12
        ' 
        ' TextBoxPname
        ' 
        TextBoxPname.Location = New Point(786, 173)
        TextBoxPname.Margin = New Padding(4, 2, 4, 2)
        TextBoxPname.Name = "TextBoxPname"
        TextBoxPname.Size = New Size(400, 39)
        TextBoxPname.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(600, 173)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(167, 32)
        Label5.TabIndex = 10
        Label5.Text = "Product Name"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(609, 260)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 32)
        Label6.TabIndex = 8
        Label6.Text = "Expiry Date"
        ' 
        ' TextBoxQuantity
        ' 
        TextBoxQuantity.Location = New Point(321, 215)
        TextBoxQuantity.Margin = New Padding(4, 2, 4, 2)
        TextBoxQuantity.Name = "TextBoxQuantity"
        TextBoxQuantity.Size = New Size(201, 39)
        TextBoxQuantity.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(163, 220)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(106, 32)
        Label4.TabIndex = 6
        Label4.Text = "Quantity"
        ' 
        ' TextBoxPrice
        ' 
        TextBoxPrice.Location = New Point(321, 301)
        TextBoxPrice.Margin = New Padding(4, 2, 4, 2)
        TextBoxPrice.Name = "TextBoxPrice"
        TextBoxPrice.Size = New Size(201, 39)
        TextBoxPrice.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(163, 303)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 32)
        Label3.TabIndex = 4
        Label3.Text = "Price (₹)"
        ' 
        ' ButtonShow
        ' 
        ButtonShow.Location = New Point(254, 373)
        ButtonShow.Margin = New Padding(4, 2, 4, 2)
        ButtonShow.Name = "ButtonShow"
        ButtonShow.Size = New Size(150, 47)
        ButtonShow.TabIndex = 3
        ButtonShow.Text = "Insert"
        ButtonShow.UseVisualStyleBackColor = True
        ' 
        ' TextBoxPid
        ' 
        TextBoxPid.Location = New Point(321, 134)
        TextBoxPid.Margin = New Padding(4, 2, 4, 2)
        TextBoxPid.Name = "TextBoxPid"
        TextBoxPid.Size = New Size(201, 39)
        TextBoxPid.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(163, 137)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 32)
        Label2.TabIndex = 1
        Label2.Text = "Product ID"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkSalmon
        Label1.Font = New Font("Lucida Console", 16.125F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Cornsilk
        Label1.Location = New Point(384, 51)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(539, 43)
        Label1.TabIndex = 0
        Label1.Text = "Products Information"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1429, 949)
        Controls.Add(GroupBox1)
        Controls.Add(DataGridView1)
        Margin = New Padding(4, 2, 4, 2)
        Name = "Form1"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents TextBoxRec As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents Exdate As DateTimePicker
    Friend WithEvents TextBoxPname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonShow As Button
    Friend WithEvents TextBoxPid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents delExpired As CheckBox
End Class
