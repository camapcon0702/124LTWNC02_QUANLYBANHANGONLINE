<%@ Page Title="" Language="C#" MasterPageFile="~/MASTERPAGEUSER.Master" AutoEventWireup="true" CodeBehind="pageCHITIET.aspx.cs" Inherits="_124LTWNC02_QUANLYBANHANGONLINE.pageCHITIET" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="center_content">
        <div class="center_title_bar">Motorola 156 MX-VL</div>
        <div class="prod_box_big">
            <div class="top_prod_box_big"></div>
            <%--OnPageIndexChanging="chiTietSP_PageIndexChanging" (trong asp:formview)--%>
            <asp:FormView ID="chiTietSP" runat="server" >
                <ItemTemplate>
                    <div id="chiTiet" class="center_prod_box_big">
                        <div class="product_img_big">
                            <a href="javascript:popImage('images/big_pic.jpg','Some Title')" title="header=[Zoom] body=[&nbsp;] fade=[on]">
                                <img src="images/<%# Eval("HINHANH") %>" alt="" border="0" />
                                <%--<asp:Image ID="hinhAnh" runat="server" />--%>
                            </a>
                            <div class="thumbs">
                                <a href="#" title="header=[Thumb1] body=[&nbsp;] fade=[on]">
                                    <img src="images/thumb1.gif" alt="" border="0" /></a> <a href="#" title="header=[Thumb2] body=[&nbsp;] fade=[on]">
                                        <img src="images/thumb1.gif" alt="" border="0" /></a> <a href="#" title="header=[Thumb3] body=[&nbsp;] fade=[on]">
                                            <img src="images/thumb1.gif" alt="" border="0" /></a>
                            </div>
                        </div>
                        <div class="details_big_box">
                            <div class="product_title_big"><%# Eval("TENSANPHAM") %></div>
                            <div class="specifications">
                                Description: <span class="blue"><%# Eval("MOTA") %></span><br />
                                Quantity: <span class="blue"><%# Eval("SOLUONG") %></span><br />
                                Category: <span class="blue"><%# Eval("TENDANHMUC") %></span><br />
                                <%--Pretul include <span class="blue">TVA</span><br />--%>
                            </div>
                            <div class="prod_price_big"><span class="reduce">350$</span> <span class="price"><%# Eval("DONGIA") %>$</span></div>
                            <asp:ImageButton title="header=[Add to cart] body=[&nbsp;] fade=[on]" ID="Imagecart" runat="server" ImageUrl="images/cart.gif" class="left_bt" OnClick="Imagecart_Click" />
                            <%--<a href="#" class="addtocart">add to cart</a>--%>
                            <%--<a href="#" class="compare">compare</a>--%>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:FormView>


            <div class="bottom_prod_box_big"></div>
        </div>
        <div class="center_title_bar">Similar products</div>
        <div class="prod_box">
            <div class="top_prod_box"></div>
            <div class="center_prod_box">
                <div class="product_title"><a href="details.html">Motorola 156 MX-VL</a></div>
                <div class="product_img">
                    <a href="details.html">
                        <img src="images/laptop.gif" alt="" border="0" /></a>
                </div>
                <div class="prod_price"><span class="reduce">350$</span> <span class="price">270$</span></div>
            </div>
            <div class="bottom_prod_box"></div>
            <div class="prod_details_tab">
                <a href="#" title="header=[Add to cart] body=[&nbsp;] fade=[on]">
                    <img src="images/cart.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                        <img src="images/favs.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Gifts] body=[&nbsp;] fade=[on]">
                            <img src="images/favorites.gif" alt="" border="0" class="left_bt" /></a> <a href="details.html" class="prod_details">details</a>
            </div>
        </div>
        <div class="prod_box">
            <div class="top_prod_box"></div>
            <div class="center_prod_box">
                <div class="product_title"><a href="details.html">Iphone Apple</a></div>
                <div class="product_img">
                    <a href="details.html">
                        <img src="images/p4.gif" alt="" border="0" /></a>
                </div>
                <div class="prod_price"><span class="price">270$</span></div>
            </div>
            <div class="bottom_prod_box"></div>
            <div class="prod_details_tab">
                <a href="#" title="header=[Add to cart] body=[&nbsp;] fade=[on]">
                    <img src="images/cart.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                        <img src="images/favs.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Gifts] body=[&nbsp;] fade=[on]">
                            <img src="images/favorites.gif" alt="" border="0" class="left_bt" /></a> <a href="details.html" class="prod_details">details</a>
            </div>
        </div>
        <div class="prod_box">
            <div class="top_prod_box"></div>
            <div class="center_prod_box">
                <div class="product_title"><a href="details.html">Samsung Webcam</a></div>
                <div class="product_img">
                    <a href="details.html">
                        <img src="images/p5.gif" alt="" border="0" /></a>
                </div>
                <div class="prod_price"><span class="reduce">350$</span> <span class="price">270$</span></div>
            </div>
            <div class="bottom_prod_box"></div>
            <div class="prod_details_tab">
                <a href="#" title="header=[Add to cart] body=[&nbsp;] fade=[on]">
                    <img src="images/cart.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                        <img src="images/favs.gif" alt="" border="0" class="left_bt" /></a> <a href="#" title="header=[Gifts] body=[&nbsp;] fade=[on]">
                            <img src="images/favorites.gif" alt="" border="0" class="left_bt" /></a> <a href="details.html" class="prod_details">details</a>
            </div>
        </div>
    </div>
</asp:Content>
