<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aula-lista.aspx.cs" Inherits="WebFormsAula01.aula_lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A layout example with a side menu that hides on mobile, just like the Pure website.">
    <title>Responsive Side Menu &ndash; Layout Examples &ndash; Pure</title>
    <link rel="stylesheet" href="https://unpkg.com/purecss@1.0.1/build/pure-min.css" integrity="sha384-" crossorigin="anonymous">
    <!--[if lte IE 8]>
            <link rel="stylesheet" href="css/layouts/side-menu-old-ie.css">
        <![endif]-->
    <!--[if gt IE 8]><!-->
    <link rel="stylesheet" href="css/layouts/side-menu.css">
    <!--<![endif]-->
</head>
<body>
    <form id="form1" runat="server" class="pure-form pure-form-stacked">
        <fieldset>
            <legend>A Stacked Form</legend>

            <label for="email">Email</label>
            
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            
            <label for="lstEmails">Lista de Emails</label>

            <asp:ListBox ID="lstEmails" runat="server" Height="300px"></asp:ListBox>

            <asp:DropDownList ID="ddlEmail" runat="server"></asp:DropDownList>
            
            <asp:Button ID="btnAdd" runat="server" Text="Adicionar" CssClass="pure-button pure-button-primary" OnClick="btnAdd_Click" />

            <asp:Button ID="btnRemover" runat="server" Text="Remover" CssClass="pure-button pure-button-error pure-button-secondary" OnClick="btnRemover_Click" />

        </fieldset>
    </form>
</body>
</html>
    