Imports System.Data.SqlClient
Public Class frm_login
    Public nome_usuario As String
    Public usuario As String
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        usuario = txbusuario.Text
        If txbsenha.Text = "" Or txbusuario.Text = "" Then
            MsgBox("Campos obrigatórios não preenchidos!!", vbOK, "Atenção")
        Else
            Dim conexao As New SqlConnection("Data Source=DESKTOP-L4CNABK;Initial Catalog=Sistema; Integrated Security=True;")
            Dim comando As New SqlCommand
            Dim sql As String
            sql = "select fnc_usuario, fnc_senha from tblFuncionario where fnc_usuario = '" & txbusuario.Text & "' and fnc_senha = '" & txbsenha.Text & "' "
            conexao.Open()
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(sql, conexao)
            comando.Connection = conexao
            comando.CommandText = sql
            conexao.Close()
            da.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                sql = "select fnc_nome from tblFuncionario where fnc_usuario like '" & usuario & "' "
                conexao.Open()
                comando.Connection = conexao
                comando.CommandText = sql
                Dim reader As SqlDataReader = comando.ExecuteReader()
                reader.Read()
                nome_usuario = reader.GetString(0)
                reader.Close()
                conexao.Close()
                txbsenha.Clear()
                txbusuario.Clear()
                frminterface.Show()

            Else
                MsgBox("Login Inválido", vbOK, "Atenção")
                txbsenha.Clear()
                txbusuario.Clear()
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Contate o supervisor: Gustavo Pena (31) 98969-3484", vbOK, "Contato")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("Tem certeza que deseja sair?", vbYesNo, "Atenção") = vbYes) Then
            Me.Close()
        End If

    End Sub
End Class
