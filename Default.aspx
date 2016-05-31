<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWeb._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Нажмите для перехода на страницу редактирования:</h3>
    <asp:Button ID="CarFormButton" runat="server" OnClick="CarFormButton_Click" Text="Редактировать" Width="200px" />
</asp:Content>
