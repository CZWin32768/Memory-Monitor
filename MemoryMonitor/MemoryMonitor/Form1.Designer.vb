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
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MemoryChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_MemUsage = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgPriority = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.MemoryChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MemoryChart
        '
        ChartArea5.Name = "ChartArea1"
        Me.MemoryChart.ChartAreas.Add(ChartArea5)
        Legend5.Name = "Legend1"
        Me.MemoryChart.Legends.Add(Legend5)
        Me.MemoryChart.Location = New System.Drawing.Point(12, 59)
        Me.MemoryChart.Name = "MemoryChart"
        Series5.ChartArea = "ChartArea1"
        Series5.Legend = "Legend1"
        Series5.Name = "Series1"
        Me.MemoryChart.Series.Add(Series5)
        Me.MemoryChart.Size = New System.Drawing.Size(388, 146)
        Me.MemoryChart.TabIndex = 2
        Me.MemoryChart.Text = "Chart2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(194, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "System Address Space Layout："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 458)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Minimum Application Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Maximum Application Address:"
        '
        'Label_MemUsage
        '
        Me.Label_MemUsage.AutoSize = True
        Me.Label_MemUsage.Font = New System.Drawing.Font("Microsoft YaHei UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label_MemUsage.Location = New System.Drawing.Point(8, 18)
        Me.Label_MemUsage.Name = "Label_MemUsage"
        Me.Label_MemUsage.Size = New System.Drawing.Size(132, 38)
        Me.Label_MemUsage.TabIndex = 6
        Me.Label_MemUsage.Text = "Memory"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgName, Me.dgPID, Me.dgPriority})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 23
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(395, 194)
        Me.DataGridView1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Process:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(442, 59)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(405, 372)
        Me.TextBox1.TabIndex = 9
        '
        'dgName
        '
        Me.dgName.HeaderText = "Name"
        Me.dgName.Name = "dgName"
        Me.dgName.ReadOnly = True
        Me.dgName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgName.Width = 200
        '
        'dgPID
        '
        Me.dgPID.HeaderText = "PID"
        Me.dgPID.Name = "dgPID"
        Me.dgPID.ReadOnly = True
        Me.dgPID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgPID.Width = 50
        '
        'dgPriority
        '
        Me.dgPriority.HeaderText = "Priority"
        Me.dgPriority.Name = "dgPriority"
        Me.dgPriority.ReadOnly = True
        Me.dgPriority.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.MemoryMonitor.My.Resources.Resources.f
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Location = New System.Drawing.Point(382, 214)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 515)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label_MemUsage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MemoryChart)
        Me.Name = "Form1"
        Me.Text = "Memory Monitor"
        CType(Me.MemoryChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents MemoryChart As DataVisualization.Charting.Chart
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_MemUsage As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgName As DataGridViewTextBoxColumn
    Friend WithEvents dgPID As DataGridViewTextBoxColumn
    Friend WithEvents dgPriority As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
