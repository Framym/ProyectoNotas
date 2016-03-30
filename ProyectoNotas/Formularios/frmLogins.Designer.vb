<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogins
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogins))
        Me.PictureAlumno = New DevExpress.XtraEditors.PictureEdit()
        Me.PictureEmpleado = New DevExpress.XtraEditors.PictureEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureAlumno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureAlumno
        '
        Me.PictureAlumno.EditValue = CType(resources.GetObject("PictureAlumno.EditValue"), Object)
        Me.PictureAlumno.Location = New System.Drawing.Point(247, 69)
        Me.PictureAlumno.Name = "PictureAlumno"
        Me.PictureAlumno.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.PictureAlumno.Properties.Appearance.Options.UseBackColor = True
        Me.PictureAlumno.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureAlumno.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureAlumno.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureAlumno.Size = New System.Drawing.Size(197, 179)
        Me.PictureAlumno.TabIndex = 1
        '
        'PictureEmpleado
        '
        Me.PictureEmpleado.EditValue = CType(resources.GetObject("PictureEmpleado.EditValue"), Object)
        Me.PictureEmpleado.Location = New System.Drawing.Point(23, 69)
        Me.PictureEmpleado.Name = "PictureEmpleado"
        Me.PictureEmpleado.Properties.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.PictureEmpleado.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEmpleado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEmpleado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEmpleado.Size = New System.Drawing.Size(197, 179)
        Me.PictureEmpleado.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(-1, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(428, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Eliga su Tipo de Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(424, -1)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(42, 39)
        Me.LinkLabel1.TabIndex = 4
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "X"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmLogins
        '
        Me.Appearance.BackColor = System.Drawing.Color.LightGray
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 276)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureEmpleado)
        Me.Controls.Add(Me.PictureAlumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HtmlText = "Eliga su tipo de usuario"
        Me.Name = "frmLogins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureAlumno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureAlumno As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEmpleado As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
End Class
