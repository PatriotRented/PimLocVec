<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Reservar.aspx.cs" Inherits="SiteLocadora_Interface.Reservar" %>

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

    <section class="home-section text-center">


    </section>
    <div>
        <br/><br/><br/>
        <asp:Button ID="btnAbrirRes" runat="server" CssClass="btn-primary disabled" Height="45px" Text="Abrir Reserva" Width="215px" OnClick="btnAbrirRes_Click" />
        <asp:Button ID="btnCancelRes" runat="server" CssClass="btn-primary disabled" Height="45px" Text="Cancelar Reserva" Width="215px" OnClick="btnCancelRes_Click" />
        <asp:Button ID="btnConsulRes" runat="server" CssClass="btn-primary disabled" Height="45px" Text="Consultar Reservas" Width="215px" OnClick="btnConsulRes_Click" />
        <br/>
        
        <asp:Panel ID="panelAbrirRes" runat="server">
            <br />
            <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DADOS DO CLIENTE:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Dados do veículo</h5>&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;CPF/CNPJ:&nbsp;
            <asp:TextBox ID="txtCpfCnpj" runat="server" Width="210px" MaxLength="14"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; MODELO:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtModelo" runat="server" MaxLength="7"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CLIENTE:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCliente" runat="server" Width="210px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; PLACA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtPlaca" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <hr />
            <h5>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DATA DE RETIRADA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DATA DE DEVOLUÇÃO  </h5><br />
            <table>
                <tr>
                    <td >
                        
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>
                        <asp:Calendar ID="calendarRet" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="calendarRet_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                    </td>
                    <td >
                        
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td></td>
                    <td >
                        
                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Calendar ID="calendarDev" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px" OnSelectionChanged="calendarDev_SelectionChanged">
                            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
                            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
                            <OtherMonthDayStyle ForeColor="#999999" />
                            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
                            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
                            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
                            <WeekendDayStyle BackColor="#CCCCFF" />
                        </asp:Calendar>
                    </td>
                </tr>
            </table>
            <hr />
            <table>
                <tr>
                    <td>
                        &nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;</td>
                     <td>  
                         <asp:RadioButton ID="rbtnKmLivre" runat="server" BackColor="#003399" ForeColor="White" OnCheckedChanged="rbtnKmLivre_CheckedChanged" Text="KM LIVRE" />
                    </td>
                    <td >
                         &nbsp;&nbsp;<asp:RadioButton ID="rbtnKmCrtl" runat="server" BackColor="#003399" ForeColor="White" OnCheckedChanged="rbtnKmCrtl_CheckedChanged" Text="KM CONTROLADO" />
                         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;<asp:TextBox ID="txtDiaria" runat="server"></asp:TextBox>
&nbsp;
                    </td>
                    <td>
                        <asp:TextBox ID="txtValorTotal" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>

                        &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td>

                        &nbsp;&nbsp;</td>
                </tr>

            </table>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReservar0" runat="server" CssClass="btn-primary disabled focus" Font-Bold="True" Height="44px" Text="Reservar" Width="202px" OnClick="btnReservar0_Click" />
            
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="panelCancelarRes" runat="server" Visible="False">
            <br />
            <br />
            PARA CANCELAR A RESERVA DIGITE O CÓDIGO DA RESERVA AQUI:
            <asp:TextBox ID="txtCodRes" runat="server"></asp:TextBox>
            &nbsp;<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnCancel" runat="server" CssClass="btn-primary disabled focus" Height="58px" OnClick="btnCancel_Click" Text="Cancelar Reserva" Width="252px" Font-Bold="True" />
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="panelConsulRes" runat="server" Visible="False">
        </asp:Panel>
        <table>
            <tr>
                <td>
        <br/>CÓDIGO CLIENTE:&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtCodCli" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CÓDIGO RESERVA:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtRes" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        DATA DE RETIRADA: <asp:TextBox ID="txtDatRet" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; DATA DE DEVOLUÇÃO:
        <asp:TextBox ID="txtDtDev" runat="server"></asp:TextBox>
                        <br />
                        </td>
                <td>

                    <asp:Button ID="Buscar" runat="server" Height="92px" Text="Buscar" Width="133px" CssClass="btn-primary disabled focus" Font-Bold="True" />

                </td>
            </tr>
            </table>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        <br/><br/><br/>
    </div>
        					
        <section id="Contato" class="home-section text-center">
        <div class="heading-Contato">
            <div class="container">
                <div class="row">
                    <div class="col-lg-8 col-lg-offset-2">
                        <div class="wow bounceInDown" data-wow-delay="0.4s">
                            <div class="section-heading">
                                <br /><br /><br /><br /><br /><br /><br /><br />
                                <h2>Contato/h2><br /><br /><br /><br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div> 
        <div class="container">
            <div class="row">
                <div class="col-lg-8">
                    <div class="boxed-grey">
                        <form id="contact-form">
                            <div class="row">
                                <div class="col-md-12">

                                    <div class="form-group">
                                        <label for="inputEmail" class="col-lg-2 control-label">Email</label>
                                        <div class="col-lg-12">
                                            <input type="text" class="form-control" id="inputEmail" placeholder="Email"/>
                                        </div>
                                    </div>
                                    <div class="form-group">
                                        <label for="inputPassword" class="col-lg-2 control-label">Nome</label>
                                        <div class="col-lg-12">
                                            <input type="text" class="form-control" id="inputNome" placeholder="Nome Completo"/>

                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="inputPassword" class="col-lg-2 control-label">Telefone</label>
                                        <div class="col-lg-12">
                                            <input type="tel" class="form-control" id="inputTel" placeholder="Telefone Com DDD"/>

                                        </div>
                                    </div>

                                    <div class="form-group">
                                        <label for="textArea" class="col-lg-2 control-label">Messagem</label>
                                        <div class="col-lg-12">
                                            <textarea class="form-control" rows="3" id="textArea"></textarea>
                                            <span class="help-block"></span>
                                        </div>
                                    </div>


                                    <div class="form-group">
                                        <div class="col-lg-12 col-lg-offset-2">
                                            <button type="reset" class="btn btn-default">Cancelar</button>
                                            <button type="submit" class="btn btn-primary">Enviar</button>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </form>
                    </div>
                </div>

                <div class="col-lg-4">
                    <div class="widget-contact">

                        <address>
                            <strong>Horário</strong><br>
                            Segunda á Sábado das 07h30 às 23h.
                        </address>

                        <address>
                            <strong>Localidade</strong><br>

                            Rua Lord Clemente Attlee, Nº 13<br>
                            Bairro Chácara Inglesa<br>
                            CEP: 05142-020 <br>
                            São Paulo – SP<br>

                        </address>

                        <address>
                            <strong> Telefone</br> </strong>
                            (11) 3456-7890
                        </address>

                        <address>
                            <strong>Email</strong><br>
                            <a href="mailto:#">pim3semestre2016@gmail.com</a>
                        </address>
                        
                        <address>
				            <br/>
                       	<ul class="company-social">
                            <li class="social-facebook"><a href="#" target="_blank"><i class="fa fa-facebook"></i></a></li>
                            <li class="social-google"><a href="#" target="_blank"><i class="fa fa-google-plus"></i></a></li>
                        </ul>	
				        </address>


                    </div>
                </div>
            </div>

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
</div>
</form>


</body>
</html>