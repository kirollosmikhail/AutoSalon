<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="AggiungiAuto.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
   <%-- <div>
        <asp:Button ID="btnHome" runat="server" Text="Home" />
    </div>--%>

    <div id="contenuto">
        <h1>Aggiungi Auto</h1>
        <table>
            

            <tr>
                <td>
                    <asp:Label ID="lblTarga" runat="server" Text="Targa:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtTarga" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMarche" runat="server" Text="MARCHE:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMARCHE" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMARCHE_SelectedIndexChanged"></asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblModello" runat="server" Text="Modello:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMODELLI" runat="server"></asp:DropDownList>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblAnno" runat="server" Text="Anno:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAnno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:RadioButton ID="radUsata" runat="server" GroupName="UsataNuova" Text="Usata" />
                </td>
                <td>
                    <asp:RadioButton ID="radNuova" runat="server" GroupName="UsataNuova" Text="Nuova" />
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblKM" runat="server" Text="KM:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtKM" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblDescrizione" runat="server" Text="Descrizione:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDescrizione" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="lblAutosalone" runat="server" Text="Autosalone:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtAutosalone" runat="server"></asp:TextBox>
                </td>
            </tr>
        
            <tr>
                <td>
                    <asp:Label ID="lblPrezzo" runat="server" Text="Prezzo:" CssClass="lblForm"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPrezzo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lblErrore" runat="server" Text="" CssClass="lblErrore"></asp:Label>
                </td>
            </tr>
            <tr class="button">
                <td colspan="2">
                    <asp:Button ID="btnAggiungi" runat="server" Text="Aggiungi" CssClass="pulsante" OnClick="btnAggiungi_Click" />

                </td>
            </tr>

        </table>

    </div>




</asp:Content>

