using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public partial class pageCHITIET : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        DataTable tbSANPHAM;

        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU();

            String MASP = Request.QueryString.Get("MASANPHAM");
            String SQL = "select tbSANPHAM.*, TENDANHMUC from tbSANPHAM, tbDANHMUC where tbSANPHAM.MADANHMUC = tbDANHMUC.MADANHMUC and MASANPHAM =" + MASP;

            tbSANPHAM = xuly.getTable(SQL);

            chiTietSP.DataSource = tbSANPHAM;
            chiTietSP.DataBind();
        }

        protected void Imagecart_Click(object sender, ImageClickEventArgs e)
        {
            Session.Timeout = 2;
            CART cart = new CART();
            if (tbSANPHAM != null)
            {
                String masanpham = tbSANPHAM.Rows[0]["MASANPHAM"].ToString();
                String tensanpham = tbSANPHAM.Rows[0]["TENSANPHAM"].ToString();
                double dongia = Double.Parse(tbSANPHAM.Rows[0]["DONGIA"].ToString());
                String hinhanh = tbSANPHAM.Rows[0]["HINHANH"].ToString();
                if (Session["CART"] != null)
                {
                    cart = (CART)Session["CART"];
                }
                cart.AddCart(masanpham, tensanpham, hinhanh, 1, dongia);
                Session["CART"] = cart;
                Response.Redirect("pageGIOHANG.aspx");
            }
        }
    }
}