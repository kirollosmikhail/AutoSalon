<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="AggiungiMarca.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="contenuto">
        <%--form per aggiungere la marca--%>
        <div id="divSup">
            <h1>Aggiungi Marca</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblMarca" runat="server" Text="Nuova Marca:" CssClass="lblForm"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnMarca" runat="server" Text="Aggiungi" OnClick="btnMarca_Click" CssClass="pulsante" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblErroreMarca" runat="server" Text="" CssClass="lblErrore"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <hr />

    </div>




</asp:Content>

