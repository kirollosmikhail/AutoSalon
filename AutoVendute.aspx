<%@ Page Title="" Language="C#" MasterPageFile="~/MasterProp.master" AutoEventWireup="true" CodeFile="AutoVendute.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">




    <div id="contenuto">
        <div id="divSup">
            <asp:DropDownList ID="ddlMARCHE" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMARCHE_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="ddlMODELLI" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlMODELLI_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="pulsante" OnClick="btnReset_Click" />
        </div>
        <div id="divInf">

            <asp:GridView ID="gridAuto" runat="server" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal" DataKeyNames="Targa" OnSelectedIndexChanged="gridAuto_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#F7F7F7" />
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" SelectText="Modifica" />
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

        </div>



    </div>





</asp:Content>

