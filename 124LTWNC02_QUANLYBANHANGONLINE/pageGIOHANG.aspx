<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGEUSER.Master" AutoEventWireup="true" CodeBehind="pageGIOHANG.aspx.cs" Inherits="_124LTWNC02_QUANLYBANHANGONLINE.pageGIOHANG" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <div class="center_title_bar">Motorola 156 MX-VL</div>
        <asp:GridView runat="server" AutoGenerateColumns="False" ID="grvCART" ShowFooter="True">
            <Columns>
                <asp:BoundField DataField="MASANPHAM" HeaderText="M&#227; sản phẩm"></asp:BoundField>
                <asp:BoundField DataField="TENSANPHAM" HeaderText="T&#234;n sản phẩm"></asp:BoundField>
                <asp:BoundField DataField="SOLUONG" HeaderText="Số lượng"></asp:BoundField>
                <asp:BoundField DataField="DONGIA" HeaderText="Đơn gi&#225;"></asp:BoundField>
                <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGES/{0}" HeaderText="Ảnh"></asp:ImageField>
                <asp:BoundField DataField="THANHTIEN" HeaderText="Th&#224;nh tiền"></asp:BoundField>
                <asp:TemplateField HeaderText="X&#243;a">
                    <ItemTemplate>
                        <asp:CheckBox ID="ckbREMOVEITEM" runat="server"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <%--<asp:Label ID="Label1" runat="server"></asp:Label>--%>
        <asp:Button ID="btnDELETE" runat="server" Text="Trả hàng" OnClick="btnDELETE_Click" />
    </div>

</asp:Content>
