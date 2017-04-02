<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MPSeries
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MPSeries))
        Me.b_move = New System.Windows.Forms.Button()
        Me.lb_log = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb_new_path = New System.Windows.Forms.TextBox()
        Me.tb_series_path = New System.Windows.Forms.TextBox()
        Me.tb_ext_list = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tt_tooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'b_move
        '
        Me.b_move.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.b_move.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.b_move.Location = New System.Drawing.Point(23, 115)
        Me.b_move.Name = "b_move"
        Me.b_move.Size = New System.Drawing.Size(412, 37)
        Me.b_move.TabIndex = 0
        Me.b_move.Text = "Move"
        Me.b_move.UseVisualStyleBackColor = True
        '
        'lb_log
        '
        Me.lb_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lb_log.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_log.HorizontalScrollbar = True
        Me.lb_log.ItemHeight = 12
        Me.lb_log.Location = New System.Drawing.Point(23, 159)
        Me.lb_log.Name = "lb_log"
        Me.lb_log.ScrollAlwaysVisible = True
        Me.lb_log.Size = New System.Drawing.Size(412, 194)
        Me.lb_log.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To"
        '
        'tb_new_path
        '
        Me.tb_new_path.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tb_new_path.Location = New System.Drawing.Point(59, 10)
        Me.tb_new_path.Name = "tb_new_path"
        Me.tb_new_path.Size = New System.Drawing.Size(376, 20)
        Me.tb_new_path.TabIndex = 4
        '
        'tb_series_path
        '
        Me.tb_series_path.AcceptsReturn = True
        Me.tb_series_path.AllowDrop = True
        Me.tb_series_path.Location = New System.Drawing.Point(59, 36)
        Me.tb_series_path.Multiline = True
        Me.tb_series_path.Name = "tb_series_path"
        Me.tb_series_path.Size = New System.Drawing.Size(376, 46)
        Me.tb_series_path.TabIndex = 5
        Me.tt_tooltip.SetToolTip(Me.tb_series_path, "Press Enter to add a new line")
        '
        'tb_ext_list
        '
        Me.tb_ext_list.ForeColor = System.Drawing.SystemColors.WindowText
        Me.tb_ext_list.Location = New System.Drawing.Point(59, 89)
        Me.tb_ext_list.Name = "tb_ext_list"
        Me.tb_ext_list.Size = New System.Drawing.Size(376, 20)
        Me.tb_ext_list.TabIndex = 8
        Me.tt_tooltip.SetToolTip(Me.tb_ext_list, "Input file extension separated by comma. e.g. .mp4,.mkv")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Ext."
        '
        'tt_tooltip
        '
        Me.tt_tooltip.IsBalloon = True
        Me.tt_tooltip.ShowAlways = True
        '
        'MPSeries
        '
        Me.AcceptButton = Me.b_move
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(460, 365)
        Me.Controls.Add(Me.tb_ext_list)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tb_new_path)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_log)
        Me.Controls.Add(Me.b_move)
        Me.Controls.Add(Me.tb_series_path)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MPSeries"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MPSeries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents b_move As Windows.Forms.Button
    Friend WithEvents lb_log As Windows.Forms.ListBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents tb_new_path As Windows.Forms.TextBox
    Friend WithEvents tb_series_path As Windows.Forms.TextBox
    Friend WithEvents tb_ext_list As Windows.Forms.TextBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents tt_tooltip As Windows.Forms.ToolTip
End Class
