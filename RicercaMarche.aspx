<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="RicercaMarche.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div id="contenuto">
    <div id="divSup">
        <asp:Label ID="lblMarca" runat="server" Text="Marca" CssClass="lblForm"></asp:Label>
        <asp:TextBox ID="txtMarca" runat="server" ></asp:TextBox>
        <asp:Button ID="btnMarca" runat="server" Text="Cerca" CssClass="pulsante" OnClick="btnMarca_Click" />

    </div>

    <div id="divInf">
        <asp:GridView ID="gridMarce" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="Cod_Marca" OnSelectedIndexChanged="gridMarce_SelectedIndexChanged" AutoGenerateColumns="False" CssClass="griglia">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Modifica" />
                <asp:BoundField DataField="Marca" headertext="Marca" />
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

        <%--<asp:Button ID="btnAggiungi" runat="server" Text="Aggiungi" CssClass="pulsante" OnClick="btnAggiungi_Click" />--%>

    </div>




</div>








</asp:Content>

