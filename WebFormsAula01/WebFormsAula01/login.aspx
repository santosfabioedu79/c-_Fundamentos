﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebFormsAula01.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="A layout example with a side menu that hides on mobile, just like the Pure website.">
    <title>Login</title>
    <link rel="stylesheet" href="https://unpkg.com/purecss@1.0.1/build/pure-min.css" integrity="sha384-" crossorigin="anonymous">
    <!--[if lte IE 8]>
            <link rel="stylesheet" href="css/layouts/side-menu-old-ie.css">
        <![endif]-->
    <!--[if gt IE 8]><!-->
    <link rel="stylesheet" href="css/layouts/side-menu.css">
    <!--<![endif]-->
</head>
<body>
    <form id="form1" runat="server" class="pure-form pure-form-aligned">
        <fieldset>
            <div class="pure-control-group">
                <label for="name">Username</label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <span class="pure-form-message-inline">This is a required field.</span>
            </div>

            <div class="pure-control-group">
                <label for="password">Password</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            
            <div class="pure-controls">

                <asp:Button ID="submit" runat="server" Text="Submit" CssClass="pure-button pure-button-primary" OnClick="submit_Click"></asp:Button>
            </div>

            <asp:Label ID="lblMensagem" runat="server" Text=""></asp:Label>
        </fieldset>
    </form>
</body>
</html>
