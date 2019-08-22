<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="webforms_aula1.Paginas.TipoCombustivel.Lista" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="header">
        <h1>Tipo Combustível
        </h1>
        <h2>Combustível
        </h2>
    </div>




    <div class="content">
        <div class="pure-button-group">
            <asp:Button ID="btnNovoTipo"
                runat="server"
                Text="Novo Tipo"
                CssClass="pure-button button-success"
                OnClick="btnNovoTipo_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        </asp:GridView>
        <br />
    </div>
</asp:Content>
