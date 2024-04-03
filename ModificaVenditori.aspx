<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="ModificaVenditori.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="contenuto">
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblCognome" runat="server" Text="Cognome" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCognome" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblAutoSalone" runat="server" Text="AutoSalone" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlAutoSalone" runat="server"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblErrore" runat="server" Text="" CssClass="lblErrore"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSalva" runat="server" Text="Salva" CssClass="pulsante" OnClick="btnSalva_Click" />
                </td>
            </tr>
        </table>

    </div>






</asp:Content>

