<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Devolucao.aspx.cs" Inherits="SiteLocadora_Interface.Devolucao" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="UTF-8"/>

    <title>PATRIOT RETEND</title>

    <link href="../css/style1.css" rel="stylesheet" />

    <style type="text/css">

p.MsoBodyTextIndent
	{margin-bottom:.0001pt;
	text-indent:1.0cm;
	font-size:10.0pt;
	font-family:"Verdana",sans-serif;
	font-weight:bold;
	        margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
        }
 p.MsoNormal
	{margin-bottom:.0001pt;
	font-size:12.0pt;
	font-family:"Times New Roman",serif;
	        margin-left: 0cm;
            margin-right: 0cm;
            margin-top: 0cm;
        }
        </style>

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

                <asp:Button ID="Vis" runat="server" Text="Nova Vistoria"  Width="189px" style="background-color: #EE7621; text-align: center; color: #FFFFFF; font-weight: 700;" Height="35px" OnClientClick="window.open('AbrirVistoria.aspx');" OnClick="Vis_Click"/>
                <asp:Button ID="Dev" runat="server" Text="Nova Devolução" Width="189px" style="background-color: #EE7621; color: #FFFFFF; font-weight: 700;" Height="34px" OnClientClick="window.open('Devolucao.aspx');" OnClick="Dev_Click"/>
                <asp:Button ID="Sair" runat="server" Text="Sair" Width="189px" style="background-color: #EE7621; margin-top: 0px; color: #FFFFFF; font-weight: 700;" Height="34px" OnClick="Sair_Click"/>
			<br/><br/><br/><br/>

      </div>
    <div class = "form-module"  id="CodLoc">
        <br/>
        </h2>Código da locação</h2><asp:TextBox ID="txtCodLoc" runat="server" Width="500px" Height ="30px"></asp:TextBox> 
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="auto-style1" OnClick="btnBuscar_Click"/>
        
        
    </div>
    <!-- Form Module-->
    <div class="module form-module">
                   
            <h2>TERMO DE DEVOLUÇÃO</h2>
    <p class="MsoBodyTextIndent" style="height: 134px">
                   
                    Declaro, para os devidos fins, que recebi na qualidade de a Carta nº 
                    <asp:Label ID="lblCnh" runat="server" Text="00000000000"></asp:Label>
                    , enviando-nos a título de comodato e para efeito de demonstração. O veículo marca 
                    <asp:Label ID="lblMarca" runat="server" Text="00000000000000"></asp:Label>
                    , ano de 
                    <asp:Label ID="lblAnoVec" runat="server" Text="0000"></asp:Label>
                    ,placa 
                    <asp:Label ID="lblPlaca" runat="server" Text="AAA0000"></asp:Label>
&nbsp;, pelo prazo de 
                    <asp:Label ID="lblDe" runat="server" Text="00/00/0000"></asp:Label>
&nbsp;à 
                    <asp:Label ID="lblAte" runat="server" Text="00/00/0000"></asp:Label>
&nbsp;, veículo esse que se encontra em perfeito estado de conservação e funcionamento, de acordo com os termos do artigo 5º da Portaria DETIN nº 14, de 4 de dezembro de 1987, a fim de que o presente, revestido das formalidades legais inerentes, possa produzir todos os seus efeitos de direito.<br></br>
            <div>
                <br/><br/><br/><br/><br/><br/>
               <p"><u style="font-family: 'Lucida Calligraphy'; font-variant: normal; font-weight: bold; font-size: x-large">PATRIOT RETEND</u></p><br/><br/>
            </div>
            <div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="devolvido" runat="server" Text="Concluindo" Width="500px" style="background-color: #EE7621; margin-top: 0px; text-align: center; font-weight: 700; color: #FFFFFF;" OnClick="devolvido_Click"  />
        

           </div>
             
        
    </div>
  
 </form>
</body>
</html>
