﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Vistoria.aspx.cs" Inherits="SiteLocadora_Interface.Vistoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang ="PT-BR">

<head runat="server">

<meta charset="UTF-8"/>

    <title>PATRIOT RETEND</title>

    <link href="Css/style1.css" rel="stylesheet" />
    
    <style type="text/css">
        .auto-style3 {
            left: 0px;
            top: 0px;
            height: 16px;
        }
    </style>
    
</head>

<body>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="Js/index.js"></script>


    <form id="form1" runat="server">
    
    <div>

    <div class="pen-title">

        <div class="btn-group">
		
               <h1>Patriot Retend</h1>

            <a href="Vistoria.aspx">
                <asp:Button ID="Vis" runat="server" Text="Nova Vistoria" Width="189px" style="background-color: #EE7621" Height="35px" OnClick="Vis_Click" />
            </a>
           
            <a href="Devolucao.aspx">
                <asp:Button ID="Dev" runat="server" Text="Nova Devolução" Width="189px" style="background-color: #EE7621" Height="34px" OnClick="Dev_Click" />
            </a>

            <asp:Button ID="Sair" runat="server" Text="Sair" Width="189px" style="background-color: #EE7621; margin-top: 0px;" Height="34px" OnClick="Sair_Click" />
			
        </div>

    </div>

    <!-- Form Module-->
    <div class="auto-style3">
        <div class="toggle">
            </div>

        <div class="form">
            <h2>TERMO DE VISTORIA</h2>
           
                <br/><br/>

                <!--DADOS INICIAIS-->
                <fieldset>

                        <asp:TextBox ID="codFun" runat="server"  >Código de Funcionario</asp:TextBox>
                        <asp:TextBox ID="codLoc" runat="server"  >Código de Locação</asp:TextBox>
                        <asp:Button ID="Buscar" runat="server" Text="Buscar" style="background-color: #EE7621" Height="22px" Width="92px" OnClick="Buscar_Click" /> <!--OnClick="Buscar_Click"-->

                </fieldset>

                <!-- DADOS CLIENTE-->
                <fieldset>
                    
                    Dados Cliente:<br/>
                        <asp:TextBox ID="nomeResp" runat="server" MaxLength="80" Width="155px">Nome do Responsável</asp:TextBox>
                        <br/>

                </fieldset>
                <br />

                <!-- DADOS DO VEICULO -->
                <fieldset>

                    Dados do Veículo:<br/>

                        <asp:TextBox ID="placa" runat="server" >Placa</asp:TextBox>
                        <br/>
                        <asp:TextBox ID="quilo" runat="server">Quilometragem</asp:TextBox>
                    
                    
                </fieldset>
                <br />

                <!-- LISTA DE VERIFICAÇÃO -->
                <div class="radio">
                <fieldset>
                    <legend>Lista de verificação:</legend>
                        
                        <asp:CheckBox ID="limpadores" runat="server"  OnCheckedChanged="limpadores_CheckedChanged" text="Limpadores de parabrisa funcionando"/><br/>
                        <asp:CheckBox ID="acessorios" runat="server" text="Acessorios funcionando*" OnCheckedChanged="acessorio_CheckedChanged" /><br/><!--OnCheckedChanged="acessorio_CheckedChanged"-->
                        <asp:CheckBox ID="pneus" runat="server" text="Pneus" OnCheckedChanged="pneus_CheckedChanged"/><br/>
                        <asp:CheckBox ID="luz" runat="server" text="Lanternas, luz de freio, pisca-alerta e seta devem estar funcionando" OnCheckedChanged="luz_CheckedChanged"/><br/>
                        <asp:CheckBox ID="freio" runat="server" text="Freios" OnCheckedChanged="freio_CheckedChanged"/><br/>
                        <asp:CheckBox ID="comb" runat="server" text="Combustível**" OnCheckedChanged="comb_CheckedChanged"/><br/>
                        <asp:CheckBox ID="lataria" runat="server" text="Lataria" OnCheckedChanged="lataria_CheckedChanged"/><br/>
                        <asp:CheckBox ID="motor" runat="server" text="Motor" OnCheckedChanged="motor_CheckedChanged"/><br/>
                        <asp:CheckBox ID="apVaza" runat="server" text="Apresenta vazamentos" OnCheckedChanged="apVaza_CheckedChanged"/><br/>
                        <asp:CheckBox ID="apRui" runat="server" text="Apresenta ruidos estranho" OnCheckedChanged="apRui_CheckedChanged"/><br/>

                        <br/><br/>
                        
                            *Buzina, cinto de segurança, limpadores de parabrisa, Kit emergencia, espelhos, placa, vidros, espelhos retrovisores internos e externo, acessorios opcional, tapete e outros.<br/><br/>
                            ** Tanque cheio = OK e Tanque vazio ou medio: NÃO OK<br/>

                </fieldset>
                </div>
                <br />

                <!--AVALIAÇÂO FINAL-->
				
                <asp:Button ID="ok" runat="server" Text="OK" Width="152px" style="background-color: #EE7621" OnClick="ok_Click1"  /> <!--OnClick="ok_Click"-->
                <asp:Button ID="naoOK" runat="server" Text="Não OK" Width="130px" style="background-color: #EE7621" OnClick="naoOK_Click" /><!-- OnClick="naoOK_Click"-->
            </div>
        </div>
    </div>
</form>
</body>
</html>

