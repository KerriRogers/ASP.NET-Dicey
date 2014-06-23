<%@ Page Title="" Language="C#" MasterPageFile="~/DICEEv3.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="DICEEv3.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<h1>Shows I've Watched</h1> 
<div class ="main">
    
<asp:Repeater id="URLRepeater" runat="server">
   <ItemTemplate> 
      
      Title:&nbsp;&nbsp;<strong><%#Eval("Title")%></strong><br />
       Rating:&nbsp;&nbsp; <strong><%#Eval("Rating")%></strong><br />
       DateViewed:&nbsp;&nbsp; <strong><%#Eval("DateViewed")%></strong><br />
       Channel:&nbsp;&nbsp; <strong><%#Eval("Channel")%></strong><br />
       Defendent:&nbsp;&nbsp; <strong><%#Eval("Defendent")%></strong><br />
       Victim:&nbsp;&nbsp; <strong><%#Eval("Victim")%></strong><br />
       Comments:&nbsp;&nbsp;<strong><%#Eval("Comments")%></strong><br />
       URL:&nbsp;&nbsp;<strong><%#Eval("URL")%></strong>
   </ItemTemplate> 
    <SeparatorTemplate> 
      <hr />
    </SeparatorTemplate>  
</asp:Repeater>
    </div>
</asp:Content>

