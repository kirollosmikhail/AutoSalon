<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="ModificaMarche.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="contenuto">
        <h1>Modifica Marca</h1>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblMarca" runat="server" Text="Modifica Marca:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnMarca" runat="server" Text="Salva"  CssClass="pulsante" OnClick="btnMarca_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Label ID="lblErroreMarca" runat="server" Text="" CssClass="lblErrore"></asp:Label>
                </td>
            </tr>
        </table>
    </div>




</asp:Content>

