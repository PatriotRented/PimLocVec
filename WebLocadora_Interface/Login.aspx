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
            
      
        <input type="text" placeholder="Id"/>
        <input type="password" placeholder="Senha"/>

       <button style="background-color:  #EE7621">Entrar</button>
	  
    </div>
    </div> 
    </div>
    </div>
    </form>

</body>
</html>


