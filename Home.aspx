<%@ Page Title="Home" Language="C#" MasterPageFile="~/DICEEv3.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="DICEEv3.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Crime Show Compendium</h1><br /><br />
        <img src="Images/funky2.jpg" id="tv" />
    <p>Enter the url of a crime show to see if you've watched it before.</p>
    <h3>   Did I See That?</h3>
   
        <div class ="main"> 
            <asp:TextBox ID="urlEntryTextBox" runat="server" width="503px" BorderColor="White" BackColor="White"></asp:TextBox><br /><br />
                <asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="submitButton_Click" BackColor="White" Font-Bold="True" ForeColor="Black" />
                    <asp:Button ID="clearButton" runat="server" Text="Clear" OnClick="clearButton_Click" BackColor="White" Font-Bold="True" ForeColor="Black"  /><br /><br />
        
               
        </div>
   
        <div class ="main">
            <asp:Label ID="dbErrorMessage" ForeColor="Turquoise" runat="server" />
                <asp:Repeater id="URLRepeater" runat="server">
        
                    <ItemTemplate> 
                        
                        Title: <strong><%#Eval("Title")%></strong><br />
                        Rating: <strong><%#Eval("Rating")%></strong><br />
                        DateViewed: <strong><%#Eval("DateViewed")%></strong><br />
                        Comments: <strong><%#Eval("Comments")%></strong><br />

                    </ItemTemplate> 
            
             <SeparatorTemplate> 
                <hr />
            </SeparatorTemplate>  
    
     </asp:Repeater>
  </div>
</asp:Content>

