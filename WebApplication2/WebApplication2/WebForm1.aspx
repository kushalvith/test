<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HiddenField ID="Contactid" runat="server" />

        <br/>
          <br/>
        Name:&nbsp;    <asp:TextBox ID="Name" runat="server" Text="Name"></asp:TextBox >
        <br/>
        <br/>
        <br/>
        Mobile:&nbsp;    <asp:TextBox ID="Mobile" runat="server" Text="Mobile" TextMode="Number"></asp:TextBox >

         <br/>
        <br/>
        <br/>
         
        Address&nbsp;    <asp:TextBox ID="Address" runat="server" Text="Address" TextMode="MultiLine"></asp:TextBox >

          <br/>
        <br/>
        <br/>
       

    </div>
        <asp:Button ID="Save" runat="server" Text="Save" OnClick="Save_Click" />
        <br />
        <br />
        <asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" />
        <br />
        <br />
        <asp:GridView ID="show" runat="server" OnSelectedIndexChanged="show_SelectedIndexChanged">
        </asp:GridView>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
