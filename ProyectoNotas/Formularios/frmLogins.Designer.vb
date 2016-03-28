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
        CType(Me.PictureAlumno.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEmpleado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureAlumno
        '
        Me.PictureAlumno.EditValue = CType(resources.GetObject("PictureAlumno.EditValue"), Object)
        Me.PictureAlumno.Location = New System.Drawing.Point(247, 32)
        Me.PictureAlumno.Name = "PictureAlumno"
        Me.PictureAlumno.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureAlumno.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureAlumno.Size = New System.Drawing.Size(197, 179)
        Me.PictureAlumno.TabIndex = 1
        '
        'PictureEmpleado
        '
        Me.PictureEmpleado.EditValue = CType(resources.GetObject("PictureEmpleado.EditValue"), Object)
        Me.PictureEmpleado.Location = New System.Drawing.Point(23, 32)
        Me.PictureEmpleado.Name = "PictureEmpleado"
        Me.PictureEmpleado.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEmpleado.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEmpleado.Size = New System.Drawing.Size(197, 179)
        Me.PictureEmpleado.TabIndex = 2
        '
        'frmLogins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 240)
        Me.Controls.Add(Me.PictureEmpleado)
        Me.Controls.Add(Me.PictureAlumno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HtmlText = "Eliga su tipo de usuario"
        Me.Name = "frmLogins"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureAlumno.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEmpleado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureAlumno As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents PictureEmpleado As DevExpress.XtraEditors.PictureEdit
End Class
