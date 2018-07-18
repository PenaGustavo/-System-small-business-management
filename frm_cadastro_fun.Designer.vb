<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro_fun
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
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.txb_nome = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txb_endnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txb_endcidade = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txb_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txb_senha = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txb_confir = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txb_endcomp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txb_endbairro = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txb_endrua = New System.Windows.Forms.TextBox()
        Me.txb_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txb_nasc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_sair = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txb_endestado = New System.Windows.Forms.TextBox()
        Me.txb_perm = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.Location = New System.Drawing.Point(394, 328)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(75, 23)
        Me.btn_cadastrar.TabIndex = 14
        Me.btn_cadastrar.Text = "Cadastrar"
        Me.btn_cadastrar.UseVisualStyleBackColor = True
        '
        'txb_nome
        '
        Me.txb_nome.Location = New System.Drawing.Point(105, 43)
        Me.txb_nome.Name = "txb_nome"
        Me.txb_nome.Size = New System.Drawing.Size(170, 20)
        Me.txb_nome.TabIndex = 1
        '
        'Nome
        '
        Me.Nome.AutoSize = True
        Me.Nome.Location = New System.Drawing.Point(58, 46)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(35, 13)
        Me.Nome.TabIndex = 5
        Me.Nome.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nascimento"
        '
        'txb_endnum
        '
        Me.txb_endnum.Location = New System.Drawing.Point(105, 146)
        Me.txb_endnum.Name = "txb_endnum"
        Me.txb_endnum.Size = New System.Drawing.Size(170, 20)
        Me.txb_endnum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Número"
        '
        'txb_endcidade
        '
        Me.txb_endcidade.Location = New System.Drawing.Point(349, 146)
        Me.txb_endcidade.Name = "txb_endcidade"
        Me.txb_endcidade.Size = New System.Drawing.Size(170, 20)
        Me.txb_endcidade.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Usuário"
        '
        'txb_usuario
        '
        Me.txb_usuario.Location = New System.Drawing.Point(105, 224)
        Me.txb_usuario.Name = "txb_usuario"
        Me.txb_usuario.Size = New System.Drawing.Size(170, 20)
        Me.txb_usuario.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Senha"
        '
        'txb_senha
        '
        Me.txb_senha.Location = New System.Drawing.Point(105, 250)
        Me.txb_senha.Name = "txb_senha"
        Me.txb_senha.Size = New System.Drawing.Size(170, 20)
        Me.txb_senha.TabIndex = 11
        Me.txb_senha.UseSystemPasswordChar = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(288, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Permissão"
        '
        'txb_confir
        '
        Me.txb_confir.Location = New System.Drawing.Point(105, 276)
        Me.txb_confir.Name = "txb_confir"
        Me.txb_confir.Size = New System.Drawing.Size(170, 20)
        Me.txb_confir.TabIndex = 12
        Me.txb_confir.UseSystemPasswordChar = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(304, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cidade"
        '
        'txb_endcomp
        '
        Me.txb_endcomp.Location = New System.Drawing.Point(105, 171)
        Me.txb_endcomp.Name = "txb_endcomp"
        Me.txb_endcomp.Size = New System.Drawing.Size(170, 20)
        Me.txb_endcomp.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Bairro"
        '
        'txb_endbairro
        '
        Me.txb_endbairro.Location = New System.Drawing.Point(349, 120)
        Me.txb_endbairro.Name = "txb_endbairro"
        Me.txb_endbairro.Size = New System.Drawing.Size(170, 20)
        Me.txb_endbairro.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(72, 123)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Rua"
        '
        'txb_endrua
        '
        Me.txb_endrua.Location = New System.Drawing.Point(105, 120)
        Me.txb_endrua.Name = "txb_endrua"
        Me.txb_endrua.Size = New System.Drawing.Size(170, 20)
        Me.txb_endrua.TabIndex = 4
        '
        'txb_cpf
        '
        Me.txb_cpf.Location = New System.Drawing.Point(493, 43)
        Me.txb_cpf.Mask = "000,000,000-00"
        Me.txb_cpf.Name = "txb_cpf"
        Me.txb_cpf.Size = New System.Drawing.Size(83, 20)
        Me.txb_cpf.TabIndex = 3
        Me.txb_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(460, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "CPF"
        '
        'txb_nasc
        '
        Me.txb_nasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txb_nasc.Location = New System.Drawing.Point(349, 43)
        Me.txb_nasc.Name = "txb_nasc"
        Me.txb_nasc.Size = New System.Drawing.Size(103, 20)
        Me.txb_nasc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Complemento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Confirma senha"
        '
        'btn_sair
        '
        Me.btn_sair.Location = New System.Drawing.Point(501, 328)
        Me.btn_sair.Name = "btn_sair"
        Me.btn_sair.Size = New System.Drawing.Size(75, 23)
        Me.btn_sair.TabIndex = 15
        Me.btn_sair.Text = "Sair"
        Me.btn_sair.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(304, 174)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Estado"
        '
        'txb_endestado
        '
        Me.txb_endestado.Location = New System.Drawing.Point(349, 171)
        Me.txb_endestado.Name = "txb_endestado"
        Me.txb_endestado.Size = New System.Drawing.Size(170, 20)
        Me.txb_endestado.TabIndex = 8
        '
        'txb_perm
        '
        Me.txb_perm.FormattingEnabled = True
        Me.txb_perm.Items.AddRange(New Object() {"Administrador", "Auxiliar"})
        Me.txb_perm.Location = New System.Drawing.Point(349, 245)
        Me.txb_perm.Name = "txb_perm"
        Me.txb_perm.Size = New System.Drawing.Size(170, 21)
        Me.txb_perm.TabIndex = 13
        '
        'frm_cadastro_fun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 363)
        Me.Controls.Add(Me.txb_perm)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txb_endestado)
        Me.Controls.Add(Me.btn_sair)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txb_nasc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txb_cpf)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txb_confir)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txb_endcomp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txb_endbairro)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txb_endrua)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txb_senha)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txb_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txb_endcidade)
        Me.Controls.Add(Me.txb_endnum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.txb_nome)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Name = "frm_cadastro_fun"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de funcionários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cadastrar As System.Windows.Forms.Button
    Friend WithEvents txb_nome As System.Windows.Forms.TextBox
    Friend WithEvents Nome As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txb_endnum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txb_endcidade As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txb_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txb_senha As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txb_confir As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txb_endcomp As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txb_endbairro As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txb_endrua As System.Windows.Forms.TextBox
    Friend WithEvents txb_cpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txb_nasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_sair As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txb_endestado As System.Windows.Forms.TextBox
    Friend WithEvents txb_perm As System.Windows.Forms.ComboBox
End Class
