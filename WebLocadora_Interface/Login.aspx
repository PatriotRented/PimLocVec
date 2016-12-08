<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SiteLocadora_Interface.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<meta charset="UTF-8"/>

  <title>PATRIOT RETEND</title>

    <link rel='stylesheet prefetch' href='http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css'/>
    <link href="Css/style1.css" rel="stylesheet" />
    

</head>

<body>

    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="Js/index.js"></script>
    

    <form id="form1" runat="server">

    <div>

    <div id="fundo">
        <div class="pen-title">
            <h1> Fazer login para prosseguir para o acesso na Patriot Retend</h1>
        </div>

        <!-- Form Module-->
    <div class="module form-module">
        <div class="toggle"><i class="fa fa-times fa-pencil"></i>
        </div>
  
    <div class="form">
        <h2>Login</h2>
            
      <!--<asp:Button runat="server" Text="Button"></asp:Button><asp:TextBox runat="server"></asp:TextBox>-->
        <asp:TextBox runat="server" placeholder="Id" ID="txtUsu" />
        <asp:TextBox runat="server" type="password" placeholder="Senha" ID="txtSenha" MaxLength="8"/>

       <asp:Button runat="server" style="background-color:  #EE7621" ID="btnLogin" Text="Entrar" OnClick="btnLogin_Click"></asp:Button>
	  
    </div>
    </div> 
    </div>
    </div>
    </form>

</body>
</html>


