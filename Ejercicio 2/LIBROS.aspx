<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LIBROS.aspx.cs" Inherits="EXAMEN_PROGRA_2.LIBROS1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
LIBROS
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>


<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView runat="server" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged" DataSourceID="SqlDLIBROS"></asp:GridView>
        <asp:SqlDataSource runat="server" ID="SqlDLIBROS" ConnectionString="<%$ ConnectionStrings:EXAMEN4ConnectionString %>" ProviderName="<%$ ConnectionStrings:EXAMEN4ConnectionString.ProviderName %>" SelectCommand="A"></asp:SqlDataSource>
        <asp:SqlDataSource runat="server" ID="LIBROS"></asp:SqlDataSource>
    </form>
</body>
</html>
