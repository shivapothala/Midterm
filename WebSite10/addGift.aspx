<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addGift.aspx.cs" Inherits="addGift" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Add New Items</h2>
      <div id="status" runat="server"></div>
        <ul>

            <li>

                <label>Item Name</label>
                <asp:TextBox ID="Item_name" runat="server"></asp:TextBox>
            </li>

             <li>

                <label>Registry Name</label>
               
                 <asp:DropDownList ID="Registries" runat="server" OnSelectedIndexChanged="Registries_SelectedIndexChanged">
                     <asp:ListItem>Wedding</asp:ListItem>
                     <asp:ListItem>Birthday</asp:ListItem>
                     <asp:ListItem>Graduation</asp:ListItem>
                     <asp:ListItem>Anniversary</asp:ListItem>
                     <asp:ListItem></asp:ListItem>
                 </asp:DropDownList>
                             </li>

            <li>

                <label>Item Color</label>
                <asp:TextBox ID="Item_color" runat="server"></asp:TextBox>
            </li>

             <li>

                <label>Product URL</label>
                <asp:TextBox ID="Item_URL" runat="server"></asp:TextBox>
            </li>

          
             <li>

                <label>Description</label>
                <asp:TextBox ID="description" runat="server"></asp:TextBox>
            </li>

            <li>

                <label>Status</label>
                <asp:TextBox ID="Item_status" runat="server"></asp:TextBox>
            </li>

            <li>

                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
            </li>
            
        </ul>
    </div>
  
</asp:Content>
