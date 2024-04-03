<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="AggiungiAutoSaloni.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <div id="contenuto">
     <h1>Aggiungi Autosaloni</h1>
     <table id=" tabModello">
     
         <tr>
             <td>
                 <asp:Label ID="lblIndirizzo" runat="server" Text="Nuovo Indirizzo:" CssClass="lblForm"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtIndirizzo" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="lblCap" runat="server" Text="Cap:" CssClass="lblForm"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtCap" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="lblCitta" runat="server" Text="Citta:" CssClass="lblForm"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtCitta" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="lblTelefono" runat="server" Text="Telefono"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td>
                 <asp:Label ID="lblCodVenditore_Respons" runat="server" Text="Responsabile"></asp:Label>
             </td>
             <td>
                 <asp:TextBox ID="txtCVResponsabile" runat="server"></asp:TextBox>
             </td>
         </tr>
         <tr>
             <td colspan="2">
                 <asp:Label ID="lblErroreModelli" runat="server" Text="" CssClass="lblErrore"></asp:Label>
             </td>
         </tr>
         <tr class="button">
             <td colspan="2">
                 <asp:Button ID="btnAutosalone" runat="server" Text="Aggiungi" CssClass="pulsante" OnClick="btnAutosalone_Click" />
             </td>
         </tr>
     </table>
 </div>


</asp:Content>

