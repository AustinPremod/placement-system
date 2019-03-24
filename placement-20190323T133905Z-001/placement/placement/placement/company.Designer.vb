<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class company
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(company))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TenthmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TwelthmkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoarrearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArrearsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompanyBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New placement.DatabaseDataSet()
        Me.CompanyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CompanyTableAdapter = New placement.DatabaseDataSetTableAdapters.companyTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CompnameDataGridViewTextBoxColumn, Me.TenthmkDataGridViewTextBoxColumn, Me.TwelthmkDataGridViewTextBoxColumn, Me.PhnoDataGridViewTextBoxColumn, Me.MarkDataGridViewTextBoxColumn, Me.NoarrearsDataGridViewTextBoxColumn, Me.ArrearsDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CompanyBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(838, 415)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'CompnameDataGridViewTextBoxColumn
        '
        Me.CompnameDataGridViewTextBoxColumn.DataPropertyName = "compname"
        Me.CompnameDataGridViewTextBoxColumn.HeaderText = "compname"
        Me.CompnameDataGridViewTextBoxColumn.Name = "CompnameDataGridViewTextBoxColumn"
        '
        'TenthmkDataGridViewTextBoxColumn
        '
        Me.TenthmkDataGridViewTextBoxColumn.DataPropertyName = "tenthmk"
        Me.TenthmkDataGridViewTextBoxColumn.HeaderText = "tenthmk"
        Me.TenthmkDataGridViewTextBoxColumn.Name = "TenthmkDataGridViewTextBoxColumn"
        '
        'TwelthmkDataGridViewTextBoxColumn
        '
        Me.TwelthmkDataGridViewTextBoxColumn.DataPropertyName = "twelthmk"
        Me.TwelthmkDataGridViewTextBoxColumn.HeaderText = "twelthmk"
        Me.TwelthmkDataGridViewTextBoxColumn.Name = "TwelthmkDataGridViewTextBoxColumn"
        '
        'PhnoDataGridViewTextBoxColumn
        '
        Me.PhnoDataGridViewTextBoxColumn.DataPropertyName = "phno"
        Me.PhnoDataGridViewTextBoxColumn.HeaderText = "phno"
        Me.PhnoDataGridViewTextBoxColumn.Name = "PhnoDataGridViewTextBoxColumn"
        '
        'MarkDataGridViewTextBoxColumn
        '
        Me.MarkDataGridViewTextBoxColumn.DataPropertyName = "mark"
        Me.MarkDataGridViewTextBoxColumn.HeaderText = "mark"
        Me.MarkDataGridViewTextBoxColumn.Name = "MarkDataGridViewTextBoxColumn"
        '
        'NoarrearsDataGridViewTextBoxColumn
        '
        Me.NoarrearsDataGridViewTextBoxColumn.DataPropertyName = "noarrears"
        Me.NoarrearsDataGridViewTextBoxColumn.HeaderText = "noarrears"
        Me.NoarrearsDataGridViewTextBoxColumn.Name = "NoarrearsDataGridViewTextBoxColumn"
        '
        'ArrearsDataGridViewTextBoxColumn
        '
        Me.ArrearsDataGridViewTextBoxColumn.DataPropertyName = "arrears"
        Me.ArrearsDataGridViewTextBoxColumn.HeaderText = "arrears"
        Me.ArrearsDataGridViewTextBoxColumn.Name = "ArrearsDataGridViewTextBoxColumn"
        '
        'CompanyBindingSource1
        '
        Me.CompanyBindingSource1.DataMember = "company"
        Me.CompanyBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyBindingSource
        '
        Me.CompanyBindingSource.DataMember = "company"
        Me.CompanyBindingSource.DataSource = Me.DatabaseDataSet
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(388, 443)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 24)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "REGESTER"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(519, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "REMOVE"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(641, 444)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 24)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(269, 443)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 24)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "SEARCH"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(27, 443)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 22)
        Me.TextBox1.TabIndex = 5
        '
        'CompanyTableAdapter
        '
        Me.CompanyTableAdapter.ClearBeforeFill = True
        '
        'company
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(869, 490)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "company"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "company"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DatabaseDataSet As placement.DatabaseDataSet
    Friend WithEvents CompanyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyTableAdapter As placement.DatabaseDataSetTableAdapters.companyTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TenthmkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TwelthmkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoarrearsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArrearsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CompanyBindingSource1 As System.Windows.Forms.BindingSource
End Class
