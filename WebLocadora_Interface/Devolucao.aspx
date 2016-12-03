<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Devolucao.aspx.cs" Inherits="SiteLocadora_Interface.Devolucao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8"/>

    <title>PATRIOT RETEND</title>

    <link href="../css/style1.css" rel="stylesheet" />

    </head>
<body>
    <form id="form1" runat="server">
    <div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>
    <script src="../js/index.js"></script>

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
            
            <h2>TERMO DE DEVOLUÇÃO</h2>
    
                <br/><br/>
          
                        <asp:TextBox ID="placa" runat="server">Placa</asp:TextBox>
            
                        <br/>

                        <asp:Button ID="devolvido" runat="server" Text="Concluindo" Width="415px" style="background-color: #EE7621; margin-top: 0px; text-align: center; font-weight: 700; color: #FFFFFF;" />
        

            </div>
        </div>
    </div>
 </form>
</body>
</html>
