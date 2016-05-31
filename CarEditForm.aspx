<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarEditForm.aspx.cs" Inherits="MyWeb.CarEditForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="CarForm" runat="server">
    <div>
        <asp:Button ID="CatListButton" runat="server" OnClick="CarListButton_Click" Text="Считать с id из параметров адресной строки" Width="270px" />
    </div>
    <div>
        <h3>Номер - Цвет - Тип кузова - Марка - Модель:</h3>
        <asp:TextBox ID="CarNumber" runat="server" Width="52px" />
        <asp:TextBox ID="CarColor" runat="server" Width="65px" />
        <asp:TextBox ID="CarBodyType" runat="server" Width="75px" />
        <asp:TextBox ID="CarMark" runat="server" Width="94px" />
        <asp:TextBox ID="CarModel" runat="server" Width="63px" />
    </div>
    <div>
        <h3>Название двигателя - Объем - Крутящий момент - Мощность:</h3>
        <asp:TextBox ID="EngineName" runat="server" Width="160px" />
        <asp:TextBox ID="EngineVolume" runat="server" Width="70px" />
        <asp:TextBox ID="EngineTorque" runat="server" Width="158px" />
        <asp:TextBox ID="EnginePower" runat="server" Width="116px" />
        <asp:TextBox ID="EngineId" runat="server" Width="160px" Visible="False" />
    </div>
    <div>
        <asp:Button ID="CarSendButton" runat="server" OnClick="CarSendButton_Click" Text="Редактировать" Width="95px" />
    </div>
    </form>
</body>
</html>
