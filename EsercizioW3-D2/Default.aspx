<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EsercizioW3_D2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <input type="text" id="username" runat="server" />
        <input type="text" id="password" runat="server" />
        <asp:Button ID="log" runat="server" Text="Login" OnClick="Login"/>
    </main>

</asp:Content>
