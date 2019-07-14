<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="BankEntry" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<link href="CSS/Custom.css" rel="stylesheet" />
<!------ Include the above in your HEAD tag ---------->

<div class="wrapper fadeInDown">
  <div id="formContent">
    <!-- Tabs Titles -->

    <!-- Icon -->
    <div class="fadeIn first">
         <asp:Label ID="Label1" runat="server" Text="Label" Visible="false">
             <h1 style="color:green">Login sucess Welcome..!!</h1></asp:Label>
          <asp:Label ID="Label2" runat="server" Text="Label" Visible="false">
              <h1 style="color:orangered"> Invalid Login please check username and password</h1></asp:Label>
      <h2 class="align-content-center">Login</h2>
    </div>

    <!-- Login Form -->
    
      <asp:TextBox ID="TextBox1" runat="server" class="fadeIn second" name="login" placeholder="login"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" Type="password" class="fadeIn third" name="login" placeholder="password" ></asp:TextBox>
      
        <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="fadeIn third" OnClick="Submit_Click"></asp:Button>
        
   

    <!-- Remind Passowrd -->
    <div id="formFooter">
      <a class="underlineHover" href="#">Forgot Password?</a>
    </div>

  </div>
</div>
 
</asp:Content>

