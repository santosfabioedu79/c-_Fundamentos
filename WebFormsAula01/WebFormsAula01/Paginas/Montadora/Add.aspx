<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebFormsAula01.Paginas.Montadora.Add" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h1>Montadora</h1>
        <h2>Cadastrar novas Montadoras</h2>
    </div>
    <div class="content">
        <div class="pure-form pure-form-stacked">
        <fieldset>
            <legend>Formulário de cadastro</legend>
            <label for="email">Nome Montadora</label>
            <asp:TextBox ID="txtNomeMontadora" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvNomeMontadora" runat="server" ErrorMessage="Campo Obrigatório" ControlToValidate="txtNomeMontadora"></asp:RequiredFieldValidator><br>
            <asp:Button ID="btnCadastrar" runat="server" CssClass="pure-button pure-button-primary" Text="Salvar" OnClick="btnCadastrar_Click" />
            <asp:Button ID="btnCancelar" runat="server" CssClass="pure-button button-error" Text="Cancelar" CausesValidation="false" COnClick="btnCancelar_Click" />
            <asp:Button ID="btnAdicionar" runat="server" CssClass="pure-button pure-button-primary" Text="Adicionar" CausesValidation="false" OnClick="btnAdicionar_Click" />            
        </fieldset>


        </div>
    </div>
</asp:Content>
