<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div id="frontend">
        <table>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtLoginUSR" runat="server" placeholder="UTENTE"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td colspan="2">
                    <asp:TextBox ID="txtLoginPWD" runat="server" TextMode="Password" placeholder="PASSWORD"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td colspan="1">
                    <asp:Button ID="btnLogin" runat="server" Text="Accedi" OnClick="btnLogin_Click" />
                </td>

                <td colspan="1">
                    <asp:Button ID="btnRecuperare" runat="server" Text="Recupero Password" OnClick="btnRecuperare_Click" /></td>
            </tr>


        </table>
    </div>
</asp:Content>

