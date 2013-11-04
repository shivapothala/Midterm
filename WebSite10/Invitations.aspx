<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Invitations.aspx.cs" Inherits="Invitations" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <div>
        Enter your Invitees email address with comma separation
        <asp:TextBox ID="emails" runat="server"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="Send Invitation" OnClick="Button1_Click" />
    </div>
</asp:Content>
