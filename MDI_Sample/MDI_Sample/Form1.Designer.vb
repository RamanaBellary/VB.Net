<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewIssuerMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSecurityMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewIssuerSecurityMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSecurityMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchIssuersMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchSecuritiesMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(888, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewIssuerMenuItem, Me.NewSecurityMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.MenuToolStripMenuItem.Text = "New"
        '
        'NewIssuerMenuItem
        '
        Me.NewIssuerMenuItem.Name = "NewIssuerMenuItem"
        Me.NewIssuerMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewIssuerMenuItem.Text = "Issuer"
        '
        'NewSecurityMenuItem
        '
        Me.NewSecurityMenuItem.Name = "NewSecurityMenuItem"
        Me.NewSecurityMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewSecurityMenuItem.Text = "Security"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewIssuerSecurityMenuItem, Me.ViewSecurityMenuItem, Me.SearchIssuersMenuItem, Me.SearchSecuritiesMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ViewIssuerSecurityMenuItem
        '
        Me.ViewIssuerSecurityMenuItem.Name = "ViewIssuerSecurityMenuItem"
        Me.ViewIssuerSecurityMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ViewIssuerSecurityMenuItem.Text = "Issuer"
        '
        'ViewSecurityMenuItem
        '
        Me.ViewSecurityMenuItem.Name = "ViewSecurityMenuItem"
        Me.ViewSecurityMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ViewSecurityMenuItem.Text = "Security"
        '
        'SearchIssuersMenuItem
        '
        Me.SearchIssuersMenuItem.Name = "SearchIssuersMenuItem"
        Me.SearchIssuersMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SearchIssuersMenuItem.Text = "Search Issuers"
        '
        'SearchSecuritiesMenuItem
        '
        Me.SearchSecuritiesMenuItem.Name = "SearchSecuritiesMenuItem"
        Me.SearchSecuritiesMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SearchSecuritiesMenuItem.Text = "Search Securities"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 441)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "MainForm"
        Me.Text = "Security Master Tool"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewIssuerMenuItem As ToolStripMenuItem
    Friend WithEvents NewSecurityMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewIssuerSecurityMenuItem As ToolStripMenuItem
    Friend WithEvents ViewSecurityMenuItem As ToolStripMenuItem
    Friend WithEvents SearchIssuersMenuItem As ToolStripMenuItem
    Friend WithEvents SearchSecuritiesMenuItem As ToolStripMenuItem
End Class
