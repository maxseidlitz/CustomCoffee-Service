<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlleKreationen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvKreationen = New System.Windows.Forms.DataGridView()
        Me.btnLaden = New System.Windows.Forms.Button()
        CType(Me.dgvKreationen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvKreationen
        '
        Me.dgvKreationen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKreationen.Location = New System.Drawing.Point(12, 12)
        Me.dgvKreationen.Name = "dgvKreationen"
        Me.dgvKreationen.Size = New System.Drawing.Size(776, 392)
        Me.dgvKreationen.TabIndex = 0
        '
        'btnLaden
        '
        Me.btnLaden.Location = New System.Drawing.Point(713, 415)
        Me.btnLaden.Name = "btnLaden"
        Me.btnLaden.Size = New System.Drawing.Size(75, 23)
        Me.btnLaden.TabIndex = 1
        Me.btnLaden.Text = "laden"
        Me.btnLaden.UseVisualStyleBackColor = True
        '
        'frmAlleKreationen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLaden)
        Me.Controls.Add(Me.dgvKreationen)
        Me.Name = "frmAlleKreationen"
        Me.ShowIcon = False
        Me.Text = "Alle Kreationen"
        CType(Me.dgvKreationen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvKreationen As DataGridView
    Friend WithEvents btnLaden As Button
End Class
