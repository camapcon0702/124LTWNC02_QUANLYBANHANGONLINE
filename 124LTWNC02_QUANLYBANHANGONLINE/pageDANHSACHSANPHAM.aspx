<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGEUSER.Master" AutoEventWireup="true" CodeBehind="pageDANHSACHSANPHAM.aspx.cs" Inherits="_124LTWNC02_QUANLYBANHANGONLINE.pageDANHSACHSANPHAM" %>

<asp:Content id="Conten1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <asp:DataList ID="DataList_SANPHAM" runat="server">
            <ItemTemplate>
                <div class="prod_box">
                    <div class="top_prod_box"></div>
                    <div class="center_prod_box">
                        <div class="product_title"><a href="pageCHITIET.aspx?MASANPHAM=<%# Eval("MASANPHAM") %>"><%# Eval("TENSANPHAM") %></a></div>
                        <div class="product_img">
                            <a href="pageCHITIET.aspx?MASANPHAM=<%# Eval("MASANPHAM") %>">
                                <%--<img src="images/laptop.gif" alt="" border="0" />--%>
                                <img src="images/<%# Eval("HINHANH") %>" alt="" border="0" />
                            </a>
                        </div>
                        <div class="prod_price"><span class="reduce">350$</span> <span class="price">270$</span></div>
                    </div>
                    <div class="bottom_prod_box"></div>
                    <div class="prod_details_tab">
                        <a href="#" title="header=[Add to cart] body=[&nbsp;] fade=[on]">
                            <img src="images/cart.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                                <img src="images/favs.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Gifts] body=[&nbsp;] fade=[on]">
                                    <img src="images/favorites.gif" alt="" border="0" class="left_bt" /></a> <a href="pageCHITIET.aspx?MASANPHAM=<%# Eval("MASANPHAM") %>" class="prod_details">details</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
