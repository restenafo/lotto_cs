<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link href="bootstrap/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <!-- GIOCO DEL LOTTO
                REQUISITI: 
                 - interfaccia grafica;
                 - code behind;
     -->
    <div class="container">
        <form id="form1" runat="server">
            <div>
                <h1 class="d-flex justify-content-center titolo align-content-center">GIOCO DEL LOTTO</h1>
                <h4 class="d-flex justify-content-center sottotitolo">Tenta la Fortuna!!!</h4>
            </div>
            <p class="d-flex justify-content-center istruzioni">
                FATE LA VOSTRA GIOCATA
            </p>

            <asp:Table ID="TBLnumeri" CssClass="table table-borderless" runat="server"></asp:Table>

            <div class="d-flex justify-content-center ruote">
                <asp:CheckBox ID="CHKnazionale" CssClass="ruota" runat="server" Text="Nazionale" />
                <asp:CheckBox ID="CHKbari" CssClass="ruota" runat="server" Text="Bari" />
                <asp:CheckBox ID="CHKcagliari" CssClass="ruota" runat="server" Text="Cagliari" />
                <asp:CheckBox ID="CHKfirenze" CssClass="ruota" runat="server" Text="Firenze" />
                <asp:CheckBox ID="CHKgenova" CssClass="ruota" runat="server" Text="Genova" />
                <asp:CheckBox ID="CHKmilano" CssClass="ruota" runat="server" Text="Milano" />
                <asp:CheckBox ID="CHKnapoli" CssClass="ruota" runat="server" Text="Napoli" />
                <asp:CheckBox ID="CHKpalermo" CssClass="ruota" runat="server" Text="Palermo" />
                <asp:CheckBox ID="CHKroma" CssClass="ruota" runat="server" Text="Roma" />
                <asp:CheckBox ID="CHKTorino" CssClass="ruota" runat="server" Text="Torino" />
                <asp:CheckBox ID="CHKvenezia" CssClass="ruota" runat="server" Text="Venezia" />
            </div>
            <div class="d-flex justify-content-center distanzia">
                <asp:Button ID="BTNgiocata" runat="server" Text="Invia la giocata" OnClick="BTNgiocata_Click" />
            </div>
            <div class="d-flex justify-content-center distanzia">
                <asp:Button ID="BTNestrazione" runat="server" Text="Effettua l'estrazione" OnClick="BTNestrazione_Click" />
            </div>
<%--            <div class="d-flex justify-content-center distanzia">
                <asp:Button ID="BTNverificaGiocata" runat="server" Text="Verifica la tua Giocata" OnClick="BTNverificaGiocata_Click" />
            </div>--%>
            <div class="d-flex justify-content-center distanzia">
                <asp:Label ID="LBLnumeriGiocati" runat="server" Text=""></asp:Label>
            </div>
            <div class="d-flex justify-content-center distanzia">
                <asp:Label ID="LBLrisultatoEstrazione" runat="server" Text=""></asp:Label>
            </div>
            <div class="d-flex justify-content-center distanzia">
                <asp:Label ID="LBLresponso" runat="server" Text=""></asp:Label>
            </div>
            <asp:Table ID="TBLestrazione" CssClass="table table-bordered" runat="server"></asp:Table>

        </form>
    </div>
</body>
</html>
