<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AbrirVistoria.aspx.cs" Inherits="SiteLocadora_Interface.AbrirVistoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang ="PT-BR">

<head runat="server">

<meta charset="UTF-8"/>

    <title>PATRIOT RETEND</title>

    <link href="Css/style1.css" rel="stylesheet" />
   

</head>

<body>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="Js/index.js"></script>

    <form id="form3000" runat="server">
        
        <div>
            <div class="pen-title">
        
                <div class="btn-group">
		
               <h1>Patriot Retend</h1>
            <br/><br/>

                <asp:Button ID="Vis" runat="server" Text="Nova Vistoria"  Width="189px" style="background-color: #EE7621; text-align: center; color: #FFFFFF; font-weight: 700;" Height="35px" OnClientClick="window.open('AbrirVistoria.aspx');"/>
                <asp:Button ID="Dev" runat="server" Text="Nova Devolução" Width="189px" style="background-color: #EE7621; color: #FFFFFF; font-weight: 700;" Height="34px" OnClientClick="window.open('Devolucao.aspx');"/>
                <asp:Button ID="Sair" runat="server" Text="Sair" Width="189px" style="background-color: #EE7621; margin-top: 0px; color: #FFFFFF; font-weight: 700;" Height="34px"/>
			<br/><br/><br/><br/>

      </div>

    <!-- Form Module-->
    <div class="module form-module">
        <div class="toggle">
            </div>

        <div class="form">
            <h2>TERMO DE VISTORIA</h2>
           
                <br/><br/>

                <!--DADOS INICIAIS-->
                <fieldset>

                        <asp:TextBox ID="codFun" runat="server">Código de Funcionario</asp:TextBox>
                        <asp:TextBox ID="codLoc" runat="server">Código de Locação</asp:TextBox><strong><asp:Button ID="Button3" runat="server" Text="Buscar" CssClass="auto-style1" />

                        </strong>

                </fieldset>
                <br/>
                <!-- DADOS CLIENTE-->
                <fieldset>
                    
                    <legend>Dados Cliente:</legend><br/>
                        <asp:TextBox ID="nomeResp" runat="server">Nome do Responsável que Acompanhou a Vistoria</asp:TextBox>
                        <br/>

                </fieldset>
                <br />

                <!-- DADOS DO VEICULO -->
                <fieldset>

                    <legend>Dados do Veículo:</legend><br/>
                    

                        <asp:TextBox ID="placa" runat="server">Placa</asp:TextBox>
                        <br/>
                        <asp:TextBox ID="quilo" runat="server">Quilometragem</asp:TextBox>
                    
                    
                </fieldset>
                <br />

                <!-- LISTA DE VERIFICAÇÃO -->
                <div class="radio">
                <fieldset>
                    <legend>Lista de verificação:</legend>
                    <br/>
                        
                        <asp:CheckBox ID="limpadores" runat="server" text="Limpadores de parabrisa funcionando"/><br/><br/>
                        <asp:CheckBox ID="acessorios" runat="server" text="Acessorios funcionando*"/><br/>
                        <asp:CheckBox ID="pneus" runat="server" text="Pneus"/><br/><br/>
                        <asp:CheckBox ID="luz" runat="server" text="Lanternas, luz de freio, pisca-alerta e seta devem estar funcionando"/><br/>
                        <asp:CheckBox ID="freio" runat="server" text="Freios"/><br/><br/>
                        <asp:CheckBox ID="comb" runat="server" text="Combustível**"/><br/>
                        <asp:CheckBox ID="lataria" runat="server" text="Lataria"/><br/><br/>
                        <asp:CheckBox ID="motor" runat="server" text="Motor"/><br/>
                        <asp:CheckBox ID="apVaza" runat="server" text="Apresenta vazamentos"/><br/><br/>
                        <asp:CheckBox ID="apRui" runat="server" text="Apresenta ruidos estranho"/><br/>

                        <br/><br/>
                        
                            *Buzina, cinto de segurança, limpadores de parabrisa, Kit emergencia, espelhos, placa, vidros, espelhos retrovisores internos e externo, acessorios opcional, tapete e outros.<br/><br/>
                            ** Tanque cheio = OK e Tanque vazio ou medio: NÃO OK<br/>
                            
                </fieldset>
                </div>
                <br />

                <!--AVALIAÇÂO FINAL-->
				
                <fieldset>
                    <legend>Avaliação Final</legend>
                    <br/>
                
                    <strong>
				
                        <asp:Button ID="ok" runat="server" Text="OK" Width="382px" CssClass="auto-style2" /><asp:Button ID="naoOK" runat="server" Text="Não OK" Width="381px" CssClass="auto-style1" />

                   </strong>

                </fieldset>

        </div>
    </div>
</div>
</div>
</form>
</body>
</html>
