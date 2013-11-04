<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Registries.aspx.cs" Inherits="Registries" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>&nbsp;HOME</strong><br />
     Registries<br />
     <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Create Registry" />
&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Manage Registry" />
&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button2" runat="server" Text="Find Registry" />
     <br />
     Gifts<br />
     <asp:Button ID="Button4" runat="server" Text="Add Item" />
&nbsp;&nbsp;&nbsp;
     <asp:Button ID="Button5" runat="server" Text="Item List" />
     <br />
     <br />
     <a href="createRegistry.aspx" data-theme="c" data-role="button" >Create Registry</a>

 <div id="innercontent" runat="server">
     <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </div>
   
</asp:Content>