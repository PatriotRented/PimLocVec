<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastrarCli.aspx.cs" Inherits="WebLocadora_Interface.CadastrarCli" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
        <meta charset="UTF-8"/>

    <title>PATRIOT RETEND</title>


    <!--Css -->

    <link href="Css/bootstrap-theme.min.css" rel="stylesheet" />
    <link href="Css/bootstrap-theme.css" rel="stylesheet" />
    <link href="Css/bootstrap.css" rel="stylesheet" />
    <link href="Css/bootstrap.min.css" rel="stylesheet" />
    <link href="Css/default.css" rel="stylesheet" />
    <link href="Css/StyleHome.css" rel="stylesheet" />
    <link href="Css/animate.css" rel="stylesheet" />

</head>

<body id="page-top" data-spy="scroll" data-target=".navbar-custom">

    <!-- Bootstrap JS -->
    <script src="Js/bootstrap.min.js"></script>
    <script src="Js/npm.js"></script>
    <script src="Js/jquery-1.10.2.js"></script>
    <script src="Js/jquery.min.js"></script>
    <script src="Js/jquery.easing.min.js"></script>
    <script src="Js/jquery.scrollTo.js"></script>
    <script src="Js/wow.min.js"></script>
    <script src="Js/custom.js"></script>
    <link href="Fonts/font-awesome.min.css" rel="stylesheet" />

    <form id="form1" runat="server">

    <div>
    <div id="preloader">

        <div id="load">

        </div>
    </div>

    <nav class="navbar navbar-custom navbar-fixed-top" role="navigation">
        <div class="container">
            <div class="navbar-header page-scroll">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-main-collapse">
                    <i class="fa fa-bars"></i>
                </button>
                <a class="navbar-brand" href="index.aspx">

                    <h1>Patriot Retend</h1>
                </a>
            </div>

        <div class="collapse navbar-collapse navbar-right navbar-main-collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="Home.html">Home</a></li>
                    <li><a href="Veiculo.html">Veículos</a></li>
                    <li><a href="#Contato">Contato</a></li>
                    <li><a href="#SobreNós">Sobre Nós</a></li>
                    <li><a href="Reservar.aspx">Reserva/Locação</a></li>
                </ul>
            </div>


        </div>

    </nav>

<section id="intro" class="intro">

        <div class="slogan">
            <h2> PATRIOT RETEND <span class="text_color"> PATRIOT RETEND </span> </h2>
        </div>
        <div class="page-scroll">
            <a href="#SobreNós" class="btn btn-circle">
                <i class="fa fa-angle-double-down animated"></i>
            </a>
        </div>
    </section>

     <section id="SobreNós" class="home-section text-center">

                            <div class="section-heading">
                                <h2>Cadastrar Cliente</h2>
                                <br />
                            </div>
                                <div class="form" >
                                      <br/>

                            Dados Pessoais:<br /> <br />
                                      

                            &nbsp;<asp:TextBox ID="nome" runat="server" Height="16px" Width="216px" >Nome Completo/RazãoSocial</asp:TextBox>          
                                      <br />
                            <asp:Label ID="dt_nascLabel" runat="server" Text="Data de Nascimento" style="text-align: left"></asp:Label><asp:Calendar ID="dt_nasc" runat="server"></asp:Calendar>
                            <asp:TextBox ID="cpf_cnpj" runat="server" Height="16px" Width="216px">CPF/CNPJ</asp:TextBox>
                            <asp:TextBox ID="cnh" runat="server" Height="16px" Width="216px">CNH</asp:TextBox><br />
                            <asp:TextBox ID="email" runat="server">E-mail</asp:TextBox>
                            <asp:TextBox ID="tel" runat="server" Height="16px" Width="216px">Telefone</asp:TextBox><br /><br />

                            Dados Endereço: <br /><br />
                            <asp:TextBox ID="rua" runat="server" Height="16px" Width="216px">Rua</asp:TextBox>
                            <asp:TextBox ID="num" runat="server" Height="16px" Width="216px">Numero</asp:TextBox>
                            <asp:TextBox ID="complemento" runat="server" Height="16px" Width="216px">Complemento</asp:TextBox>
                            <asp:TextBox ID="bairro" runat="server" Height="16px" Width="216px">Bairro</asp:TextBox><br />
                            <asp:TextBox ID="estado" runat="server" Height="16px" Width="216px">Estado</asp:TextBox>
                            <asp:TextBox ID="cidade" runat="server" Height="16px" Width="216px">Cidade</asp:TextBox>
                            <asp:TextBox ID="cep" runat="server" Height="16px" Width="216px">Cep</asp:TextBox><br /><br />
                            
                            <asp:Button ID="btnSalvarCli" runat="server" Text="Concluir Cadastro" Height="26px" Width="1417px" OnClick="salvarReser_Click"/>
              
        </div>
    </section>
        					

    <footer>
        <div class="container">
            <div class="row">
                <div class="col-md-12 col-lg-12">
                    <div class="wow shake" data-wow-delay="0.4s">
                        <div class="page-scroll marginbot-30">
                            <a href="#intro" id="totop" class="btn btn-circle">
                                <i class="fa fa-angle-double-up animated"></i>
                            </a>
                        </div>
                    </div>

                    <p>Seguros Associados</p>

                    <img src="Img/seguros.png" />

                </div>
            </div>
        </div>
    </footer>

</form>

</body>
</html>
