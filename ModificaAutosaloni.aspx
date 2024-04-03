<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="ModificaAutosaloni.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div id="contenuto">
    <h1>Modifica Autosalone</h1>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblInd" runat="server" Text="Modifica indirizzo:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtInd" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCAP" runat="server" Text="Modifica CAP:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCAP" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCitta" runat="server" Text="Modifica Città:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTelefono" runat="server" Text="Modifica Numero Telefono:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblCod_Venditore_Respons" runat="server" Text="Modifica Responsabile:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCod_Venditore_Respons" runat="server"></asp:TextBox>
            </td>
            <td></td>
            <tr>
                <td>
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" CssClass="pulsante" OnClick="btnSalva_Click" />
                </td>
            </tr>
        
        <%--<tr>
        <td colspan="3">
            <asp:Label ID="lblErroreAS" runat="server" Text="" CssClass="lblErrore"></asp:Label>
        </td>
    </tr>--%>
    </table>
</div>

</asp:Content>

