<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="ModificaModelli.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="contenuto">
        <h1>Modifica Modello</h1>
        <table>
            <tr>
                <td colspan="2">
                    <asp:DropDownList ID="ddlMarca" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblModello" runat="server" Text="Modifica Modello:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtModello" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAlimentazione" runat="server" Text="Alimentazione" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAlimentazione" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblAllestimento" runat="server" Text="Allestimento" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAllestimento" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblErroreModello" runat="server" Text="" CssClass="lblErrore"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnModello" runat="server" Text="Salva" CssClass="pulsante" OnClick="btnModello_Click" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

