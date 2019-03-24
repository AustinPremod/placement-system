<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentadd
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim NamLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim DeptLabel As System.Windows.Forms.Label
        Dim YeaLabel As System.Windows.Forms.Label
        Dim BatchLabel As System.Windows.Forms.Label
        Dim HomenameLabel As System.Windows.Forms.Label
        Dim PlaceLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim PinLabel As System.Windows.Forms.Label
        Dim PhnoLabel As System.Windows.Forms.Label
        Dim TenthLabel As System.Windows.Forms.Label
        Dim TwelthLabel As System.Windows.Forms.Label
        Dim CurentsemLabel As System.Windows.Forms.Label
        Dim ArrearsLabel As System.Windows.Forms.Label
        Dim NoarrearsLabel As System.Windows.Forms.Label
        Dim MarkLabel As System.Windows.Forms.Label
        Dim PlacedLabel As System.Windows.Forms.Label
        Dim RollnoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentadd))
        Me.StudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New placement.DatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox18 = New System.Windows.Forms.TextBox()
        Me.TextBox19 = New System.Windows.Forms.TextBox()
        Me.TextBox20 = New System.Windows.Forms.TextBox()
        Me.StudentTableAdapter = New placement.DatabaseDataSetTableAdapters.studentTableAdapter()
        Me.TableAdapterManager = New placement.DatabaseDataSetTableAdapters.TableAdapterManager()
        IDLabel = New System.Windows.Forms.Label()
        NamLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        DeptLabel = New System.Windows.Forms.Label()
        YeaLabel = New System.Windows.Forms.Label()
        BatchLabel = New System.Windows.Forms.Label()
        HomenameLabel = New System.Windows.Forms.Label()
        PlaceLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        PinLabel = New System.Windows.Forms.Label()
        PhnoLabel = New System.Windows.Forms.Label()
        TenthLabel = New System.Windows.Forms.Label()
        TwelthLabel = New System.Windows.Forms.Label()
        CurentsemLabel = New System.Windows.Forms.Label()
        ArrearsLabel = New System.Windows.Forms.Label()
        NoarrearsLabel = New System.Windows.Forms.Label()
        MarkLabel = New System.Windows.Forms.Label()
        PlacedLabel = New System.Windows.Forms.Label()
        RollnoLabel = New System.Windows.Forms.Label()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentBindingNavigator.SuspendLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.BackColor = System.Drawing.Color.Transparent
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(104, 60)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(33, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'NamLabel
        '
        NamLabel.AutoSize = True
        NamLabel.BackColor = System.Drawing.Color.Transparent
        NamLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamLabel.Location = New System.Drawing.Point(104, 90)
        NamLabel.Name = "NamLabel"
        NamLabel.Size = New System.Drawing.Size(48, 20)
        NamLabel.TabIndex = 3
        NamLabel.Text = "nam:"
        '
        'GenderLabel
        '
        GenderLabel.AutoSize = True
        GenderLabel.BackColor = System.Drawing.Color.Transparent
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(104, 116)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(70, 20)
        GenderLabel.TabIndex = 5
        GenderLabel.Text = "gender:"
        '
        'DeptLabel
        '
        DeptLabel.AutoSize = True
        DeptLabel.BackColor = System.Drawing.Color.Transparent
        DeptLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeptLabel.Location = New System.Drawing.Point(104, 142)
        DeptLabel.Name = "DeptLabel"
        DeptLabel.Size = New System.Drawing.Size(50, 20)
        DeptLabel.TabIndex = 7
        DeptLabel.Text = "dept:"
        '
        'YeaLabel
        '
        YeaLabel.AutoSize = True
        YeaLabel.BackColor = System.Drawing.Color.Transparent
        YeaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        YeaLabel.Location = New System.Drawing.Point(104, 168)
        YeaLabel.Name = "YeaLabel"
        YeaLabel.Size = New System.Drawing.Size(42, 20)
        YeaLabel.TabIndex = 9
        YeaLabel.Text = "yea:"
        '
        'BatchLabel
        '
        BatchLabel.AutoSize = True
        BatchLabel.BackColor = System.Drawing.Color.Transparent
        BatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BatchLabel.Location = New System.Drawing.Point(104, 194)
        BatchLabel.Name = "BatchLabel"
        BatchLabel.Size = New System.Drawing.Size(59, 20)
        BatchLabel.TabIndex = 11
        BatchLabel.Text = "batch:"
        '
        'HomenameLabel
        '
        HomenameLabel.AutoSize = True
        HomenameLabel.BackColor = System.Drawing.Color.Transparent
        HomenameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HomenameLabel.Location = New System.Drawing.Point(104, 220)
        HomenameLabel.Name = "HomenameLabel"
        HomenameLabel.Size = New System.Drawing.Size(102, 20)
        HomenameLabel.TabIndex = 13
        HomenameLabel.Text = "homename:"
        '
        'PlaceLabel
        '
        PlaceLabel.AutoSize = True
        PlaceLabel.BackColor = System.Drawing.Color.Transparent
        PlaceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlaceLabel.Location = New System.Drawing.Point(104, 246)
        PlaceLabel.Name = "PlaceLabel"
        PlaceLabel.Size = New System.Drawing.Size(57, 20)
        PlaceLabel.TabIndex = 15
        PlaceLabel.Text = "place:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.BackColor = System.Drawing.Color.Transparent
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.Location = New System.Drawing.Point(104, 272)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(41, 20)
        CityLabel.TabIndex = 17
        CityLabel.Text = "city:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.BackColor = System.Drawing.Color.Transparent
        StateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateLabel.Location = New System.Drawing.Point(104, 301)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(55, 20)
        StateLabel.TabIndex = 19
        StateLabel.Text = "state:"
        '
        'PinLabel
        '
        PinLabel.AutoSize = True
        PinLabel.BackColor = System.Drawing.Color.Transparent
        PinLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PinLabel.Location = New System.Drawing.Point(374, 62)
        PinLabel.Name = "PinLabel"
        PinLabel.Size = New System.Drawing.Size(38, 20)
        PinLabel.TabIndex = 21
        PinLabel.Text = "pin:"
        '
        'PhnoLabel
        '
        PhnoLabel.AutoSize = True
        PhnoLabel.BackColor = System.Drawing.Color.Transparent
        PhnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhnoLabel.Location = New System.Drawing.Point(374, 90)
        PhnoLabel.Name = "PhnoLabel"
        PhnoLabel.Size = New System.Drawing.Size(54, 20)
        PhnoLabel.TabIndex = 23
        PhnoLabel.Text = "phno:"
        '
        'TenthLabel
        '
        TenthLabel.AutoSize = True
        TenthLabel.BackColor = System.Drawing.Color.Transparent
        TenthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TenthLabel.Location = New System.Drawing.Point(374, 116)
        TenthLabel.Name = "TenthLabel"
        TenthLabel.Size = New System.Drawing.Size(56, 20)
        TenthLabel.TabIndex = 25
        TenthLabel.Text = "tenth:"
        '
        'TwelthLabel
        '
        TwelthLabel.AutoSize = True
        TwelthLabel.BackColor = System.Drawing.Color.Transparent
        TwelthLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TwelthLabel.Location = New System.Drawing.Point(374, 142)
        TwelthLabel.Name = "TwelthLabel"
        TwelthLabel.Size = New System.Drawing.Size(62, 20)
        TwelthLabel.TabIndex = 27
        TwelthLabel.Text = "twelth:"
        '
        'CurentsemLabel
        '
        CurentsemLabel.AutoSize = True
        CurentsemLabel.BackColor = System.Drawing.Color.Transparent
        CurentsemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CurentsemLabel.Location = New System.Drawing.Point(374, 168)
        CurentsemLabel.Name = "CurentsemLabel"
        CurentsemLabel.Size = New System.Drawing.Size(98, 20)
        CurentsemLabel.TabIndex = 29
        CurentsemLabel.Text = "curentsem:"
        '
        'ArrearsLabel
        '
        ArrearsLabel.AutoSize = True
        ArrearsLabel.BackColor = System.Drawing.Color.Transparent
        ArrearsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArrearsLabel.Location = New System.Drawing.Point(374, 194)
        ArrearsLabel.Name = "ArrearsLabel"
        ArrearsLabel.Size = New System.Drawing.Size(111, 20)
        ArrearsLabel.TabIndex = 31
        ArrearsLabel.Text = "arrears(y/n) :"
        '
        'NoarrearsLabel
        '
        NoarrearsLabel.AutoSize = True
        NoarrearsLabel.BackColor = System.Drawing.Color.Transparent
        NoarrearsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NoarrearsLabel.Location = New System.Drawing.Point(374, 220)
        NoarrearsLabel.Name = "NoarrearsLabel"
        NoarrearsLabel.Size = New System.Drawing.Size(91, 20)
        NoarrearsLabel.TabIndex = 33
        NoarrearsLabel.Text = "noarrears:"
        '
        'MarkLabel
        '
        MarkLabel.AutoSize = True
        MarkLabel.BackColor = System.Drawing.Color.Transparent
        MarkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MarkLabel.Location = New System.Drawing.Point(374, 246)
        MarkLabel.Name = "MarkLabel"
        MarkLabel.Size = New System.Drawing.Size(53, 20)
        MarkLabel.TabIndex = 35
        MarkLabel.Text = "mark:"
        '
        'PlacedLabel
        '
        PlacedLabel.AutoSize = True
        PlacedLabel.BackColor = System.Drawing.Color.Transparent
        PlacedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PlacedLabel.Location = New System.Drawing.Point(374, 272)
        PlacedLabel.Name = "PlacedLabel"
        PlacedLabel.Size = New System.Drawing.Size(67, 20)
        PlacedLabel.TabIndex = 37
        PlacedLabel.Text = "placed:"
        '
        'RollnoLabel
        '
        RollnoLabel.AutoSize = True
        RollnoLabel.BackColor = System.Drawing.Color.Transparent
        RollnoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RollnoLabel.Location = New System.Drawing.Point(374, 298)
        RollnoLabel.Name = "RollnoLabel"
        RollnoLabel.Size = New System.Drawing.Size(58, 20)
        RollnoLabel.TabIndex = 39
        RollnoLabel.Text = "rollno:"
        '
        'StudentBindingNavigator
        '
        Me.StudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentBindingNavigator.BindingSource = Me.StudentBindingSource
        Me.StudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentBindingNavigatorSaveItem})
        Me.StudentBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.StudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentBindingNavigator.Name = "StudentBindingNavigator"
        Me.StudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentBindingNavigator.Size = New System.Drawing.Size(672, 25)
        Me.StudentBindingNavigator.TabIndex = 0
        Me.StudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "student"
        Me.StudentBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'StudentBindingNavigatorSaveItem
        '
        Me.StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentBindingNavigatorSaveItem.Name = "StudentBindingNavigatorSaveItem"
        Me.StudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.StudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(226, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 32)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Add Student"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(201, 61)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 42
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(201, 90)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 43
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(201, 116)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 44
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(201, 142)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 45
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(201, 168)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 46
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(201, 194)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 47
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(201, 220)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 48
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(201, 246)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 49
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(201, 272)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 50
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(201, 301)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 51
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(484, 62)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(100, 20)
        Me.TextBox11.TabIndex = 52
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(484, 91)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.TextBox12.TabIndex = 53
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(484, 116)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.TextBox13.TabIndex = 54
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(484, 142)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 55
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(484, 168)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 56
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(484, 194)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.TextBox16.TabIndex = 57
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(484, 220)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.TextBox17.TabIndex = 58
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(484, 246)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.TextBox18.TabIndex = 59
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(484, 272)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 60
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(484, 298)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 61
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.companyTableAdapter = Nothing
        Me.TableAdapterManager.studentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.UpdateOrder = placement.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'studentadd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(672, 554)
        Me.Controls.Add(Me.TextBox20)
        Me.Controls.Add(Me.TextBox19)
        Me.Controls.Add(Me.TextBox18)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(NamLabel)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(DeptLabel)
        Me.Controls.Add(YeaLabel)
        Me.Controls.Add(BatchLabel)
        Me.Controls.Add(HomenameLabel)
        Me.Controls.Add(PlaceLabel)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(PinLabel)
        Me.Controls.Add(PhnoLabel)
        Me.Controls.Add(TenthLabel)
        Me.Controls.Add(TwelthLabel)
        Me.Controls.Add(CurentsemLabel)
        Me.Controls.Add(ArrearsLabel)
        Me.Controls.Add(NoarrearsLabel)
        Me.Controls.Add(MarkLabel)
        Me.Controls.Add(PlacedLabel)
        Me.Controls.Add(RollnoLabel)
        Me.Controls.Add(Me.StudentBindingNavigator)
        Me.Name = "studentadd"
        Me.Text = "studentadd"
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentBindingNavigator.ResumeLayout(False)
        Me.StudentBindingNavigator.PerformLayout()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DatabaseDataSet As placement.DatabaseDataSet
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentTableAdapter As placement.DatabaseDataSetTableAdapters.studentTableAdapter
    Friend WithEvents TableAdapterManager As placement.DatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StudentBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StudentBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
End Class
