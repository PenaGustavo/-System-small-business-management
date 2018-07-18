Imports System.Data.SqlClient
Public Class frm_cadastro_fun
    Private Sub btn_sair_Click(sender As Object, e As EventArgs) Handles btn_sair.Click
        Me.Close()
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim x As Integer = 0
        If txb_perm.Text <> "Administrador" And txb_perm.Text <> "Auxiliar" Then
            MsgBox("Selecione o nível de permissão!", vbOK, "Cadastro")
            x = x + 1
        End If
        If txb_confir.Text <> txb_senha.Text Then
            MsgBox("As senhas não coincidem!", vbOK, "Cadastro")
            x = x + 1
        End If
        If txb_senha.TextLength < 10 Then
            MsgBox("A senha deve ter no mínimo 10 caracteres!", vbOK, "Cadastro")
            x = x + 1
        End If
        If txb_senha.Text = "" Or txb_usuario.Text = "" Or txb_endnum.Text = "" Or txb_endrua.Text = "" Or txb_endbairro.Text = "" Or txb_endestado.Text = "" Or txb_endcidade.Text = "" Or txb_nasc.Text = Today Or txb_cpf.Text = "" Then
            MsgBox("Campos obrigatórios não preenchidos!", vbOK, "Cadastro")
            x = x + 1
        End If
        If x = 0 Then
            Dim sql As String
            Dim conexao As New SqlConnection("Data Source=DESKTOP-L4CNABK;Initial Catalog=Sistema; Integrated Security=True;")
            Dim cmd As New SqlCommand
            sql = "insert into tblFuncionario (fnc_nome,fnc_nasc,fnc_cpf,fnc_endnum,fnc_endbairro,fnc_endcidade,fnc_endrua,fnc_endestado,fnc_endcomp,fnc_usuario,fnc_senha,fnc_perm) values('" & txb_nome.Text & "','" & txb_nasc.Text & "','" & txb_cpf.Text & "','" & txb_endnum.Text & "','" & txb_endbairro.Text & "','" & txb_endcidade.Text & "','" & txb_endrua.Text & "','" & txb_endestado.Text & "','" & txb_endcomp.Text & "','" & txb_usuario.Text & "','" & txb_senha.Text & "','" & txb_perm.Text & "')"
            cmd.CommandText = sql
            cmd.Connection = conexao
            conexao.Open()
            Dim y As Integer = cmd.ExecuteNonQuery
            If y > 0 Then
                MsgBox("Cadastro realizado com sucesso!", vbOK, "Cadastro")
                conexao.Close()
                conexao = Nothing
                cmd = Nothing
                txb_confir.Clear()
                txb_cpf.Clear()
                txb_endbairro.Clear()
                txb_endcidade.Clear()
                txb_endcomp.Clear()
                txb_endestado.Clear()
                txb_endnum.Clear()
                txb_endrua.Clear()
                txb_nasc.Text = Today
                txb_nome.Clear()
                txb_perm.Text = ""
                txb_senha.Clear()
                txb_usuario.Clear()

            Else
                MsgBox("Erro ao realizar cadastro!", vbOK, "Cadastro")
                conexao.Close()
                conexao = Nothing
                cmd = Nothing

            End If
        End If
    End Sub
End Class