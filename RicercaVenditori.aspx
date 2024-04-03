<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="RicercaVenditori.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    
    <div id="contenuto">
        <div id="divSup">
            <asp:Label ID="lblNome" runat="server" Text="Nome" CssClass="lblForm"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" ></asp:TextBox>
            <asp:Button ID="btnNome" runat="server" Text="Cerca" CssClass="pulsante" OnClick="btnNome_Click" />

        </div>

        <div id="divInf">
            <asp:GridView ID="gridVenditori" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="Cod_Venditore" OnSelectedIndexChanged="gridVenditori_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Modifica" />
                </Columns>
                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                <SortedAscendingCellStyle BackColor="#F4F4FD" />
                <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
                <SortedDescendingCellStyle BackColor="#D8D8F0" />
                <SortedDescendingHeaderStyle BackColor="#3E3277" />
            </asp:GridView>

<%--            <asp:Button ID="btnAggiungi" runat="server" Text="Aggiungi" CssClass="pulsante" OnClick="btnAggiungi_Click" />--%>

        </div>




    </div>



</asp:Content>

