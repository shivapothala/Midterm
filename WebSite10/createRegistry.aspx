<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="createRegistry.aspx.cs" Inherits="createRegistry" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
      <link rel="stylesheet" href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" />
  <script src="http://code.jquery.com/jquery-1.9.1.js"></script>
  <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script>
        $(function () {
            $(".datepick").datepicker();
        });
  </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>

        <h2>Create Registry</h2>

        <div id="status" runat="server"></div>
        <ul>
            <li>
            <label>Registry Name</label>
            <asp:TextBox ID="Registry_name" runat="server"></asp:TextBox>
                </li>

             <li>
            <label>Registry Type</label>
            <asp:TextBox ID="Registry_type" runat="server"></asp:TextBox>
                </li>

              <li>
            <label>Registrant First Name</label>
            <asp:TextBox ID="Reg_first_name" runat="server"></asp:TextBox>
                </li>
            <li>
            <label>Registrant Last Name</label>
            <asp:TextBox ID="Reg_last_name" runat="server"></asp:TextBox>
                </li>

              <li>
            <label>Co-Registrant First Name</label>
            <asp:TextBox ID="Co_Reg_fname" runat="server"></asp:TextBox>
                </li>
            <li>
            <label>Co-Registrant Last Name</label>
            <asp:TextBox ID="Co_Reg_lname" runat="server"></asp:TextBox>
                </li>

              
              <li>
            <label>Event Date</label>
           <input type="text" id="datepicker" class="datepick" runat="server" />
                </li>

             <li>
            <label>Event Time</label>
            <asp:TextBox ID="event_time" runat="server"></asp:TextBox>
                </li>

              <li>
            <label>Location</label>
            <asp:TextBox ID="location" runat="server"></asp:TextBox>
                </li>

              <li>
            <label>City</label>
            <asp:TextBox ID="city" runat="server"></asp:TextBox>
                </li>
       
             <li>
         <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            </li>
            

        </ul>
    
    </div>
   
</asp:Content>        
            

