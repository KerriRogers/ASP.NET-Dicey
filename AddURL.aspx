<%@ Page Title="Add URL" Language="C#" MasterPageFile="~/DICEEv3.Master" AutoEventWireup="true" CodeBehind="AddURL.aspx.cs" Inherits="DICEEv3.AddURL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
      
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Add A Show</h1>
    
        <p>Enter url, information <br />can be updated later.</p>
            
            <div class="main">
     
    <asp:Label ID="addErrorMesssage" ForeColor ="Red" runat="server" /><br />
        
        URL:&nbsp;&nbsp;
            <asp:TextBox ID="urlTextBox" runat="server" Width="314px"></asp:TextBox><br /><br />

        Title:&nbsp;&nbsp;
            <asp:TextBox ID="titleTextBox" runat="server" Width="303px"></asp:TextBox><br /><br />

        Rating:&nbsp;&nbsp;
            <asp:TextBox ID="ratingTextBox" runat="server" Width="296px"></asp:TextBox><br /><br />

        DateViewed:&nbsp;&nbsp; 
           <asp:TextBox ID="dateTextBox" runat="server" Width="283px"></asp:TextBox><br /><br />

        Channel:&nbsp;&nbsp;
            <asp:TextBox ID="channelTextBox" runat="server" Width="291px"></asp:TextBox><br /><br />

        Defendent:&nbsp;&nbsp;
            <asp:TextBox ID="defendentTextBox" runat="server" Width="293px"></asp:TextBox><br /><br />

        Victim:&nbsp;&nbsp;
            <asp:TextBox ID="victimTextBox" runat="server" Width="303px"></asp:TextBox><br /><br />

        Comments:&nbsp;&nbsp;
            <asp:TextBox ID="commentsTextBox" runat="server" Height="64px" style="margin-top: 0px" Width="303px"></asp:TextBox><br />

        <asp:Button ID="addButton" runat="server" Text="Add" ToolTip="Add to Crime Slog" OnClick="addButton_Click"  BackColor="White" ForeColor="Black" />
            <br />

      </div>
 
</asp:Content>
