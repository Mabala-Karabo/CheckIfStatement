﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        txtYear = New TextBox()
        txtShow = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(28, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 34)
        Button1.TabIndex = 0
        Button1.Text = "SHOW MESSAGE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(406, 148)
        Button2.Name = "Button2"
        Button2.Size = New Size(197, 55)
        Button2.TabIndex = 1
        Button2.Text = "Check If Statement"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(47, 87)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter year born in"
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(205, 87)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(150, 31)
        txtYear.TabIndex = 3
        ' 
        ' txtShow
        ' 
        txtShow.AutoSize = True
        txtShow.BackColor = SystemColors.ActiveCaption
        txtShow.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point)
        txtShow.Location = New Point(460, 93)
        txtShow.Name = "txtShow"
        txtShow.Size = New Size(129, 48)
        txtShow.TabIndex = 4
        txtShow.Text = "Label2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtShow)
        Controls.Add(txtYear)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtShow As Label
End Class
