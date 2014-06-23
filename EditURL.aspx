<%@ Page Title="Edit URL" Language="C#" MasterPageFile="~/DICEEv3.Master" AutoEventWireup="true" CodeBehind="EditURL.aspx.cs" Inherits="DICEEv3.EditURL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<h1>Edit A Show</h1>
    <p>Enter the url you want to edit and click "find show".</p>
    <p>If correct show is displayed click confirm.<p>
    
        <div class ="main"> 
    
         <asp:Button ID="findShowButton" runat="server"  BackColor="White" Font-Bold="True" ForeColor="Black" Text="Find Show" OnClick="findShowButton_Click" />
        &nbsp;<asp:Button ID="clearButton" runat="server" Text="Clear" BackColor="White" Font-Bold="True" ForeColor="Black" OnClick="clearButton_Click"  />
            &nbsp;<asp:Button ID="confirmButton" runat="server" Text="Confirm" BackColor="White" ForeColor="Black" Enabled="False" Font-Bold="True" OnClick="confirmButton_Click" />
            <br /><br />
   <asp:TextBox ID="urlEditTextBox" runat="server" width="434px" BorderColor="Black"></asp:TextBox>
       <br /><br />
            
    
<asp:Repeater id="URLRepeater" runat="server">
   <ItemTemplate> 
      
    Title:  <strong><%#Eval("Title")%></strong><br />
    Rating:   <strong><%#Eval("Rating")%></strong><br />
    Defendent:   <strong><%#Eval("Defendent")%></strong><br />
    Victim:  <strong><%#Eval("Victim")%></strong><br />
     Comments:  <strong><%#Eval("Comments")%></strong><br />

       </ItemTemplate> 
    <SeparatorTemplate> 
      <hr />
    </SeparatorTemplate>  
</asp:Repeater>
            <asp:Label ID="editErrorMessage" ForeColor="Red" runat="server" />
 <hr />
<div id="hide">
   
        Title: <asp:TextBox ID="titleTextBox" runat="server" Visible="true" Width="333px"></asp:TextBox><br /><br />
         Rating:   <asp:TextBox ID="ratingTextBox" runat="server" Visible="true" Width="322px"></asp:TextBox><br /><br />
        Defendent:    <asp:TextBox ID="defendentTextBox" runat="server" Visible="true" Width="288px"></asp:TextBox><br /><br />
        Victim:    <asp:TextBox ID="victimTextBox" runat="server" Visible="true" Width="316px"></asp:TextBox><br /><br />
         Comments:   <asp:TextBox ID="commentsTextBox" runat="server" Visible="true" Width="300px"></asp:TextBox><br /><br />
</div>

            <asp:Button ID="updateButton" runat="server" Text="Update Show" Enabled="False" BackColor="White" ForeColor="Black" OnClick="updateButton_Click" />&nbsp;&nbsp;&nbsp;
            <asp:Button ID="deleteButton" runat="server" Text="Delete Show" BackColor="White" ForeColor="Black" OnClick="deleteButton_Click" />
             </div>


   

</asp:Content>
