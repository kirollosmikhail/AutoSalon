<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="AggiungiModello.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div id="contenuto">
    <h1>Aggiungi Modello</h1>
    <table id=" tabModello">
        <tr>
            <td colspan="2">
                <asp:DropDownList ID="ddlMarca" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblModello" runat="server" Text="Nuovo Modello:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtModello" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAllestimento" runat="server" Text="Allestimento:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAllestimento" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblAlimentazione" runat="server" Text="Alimentazione:" CssClass="lblForm"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtAlimentazione" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblErroreModelli" runat="server" Text="" CssClass="lblErrore"></asp:Label>
            </td>
        </tr>
        <tr class="button">
            <td colspan="2">
                <asp:Button ID="btnModello" runat="server" Text="Aggiungi" CssClass="pulsante" OnClick="btnModello_Click" />
            </td>
        </tr>
    </table>
</div>




</asp:Content>

