using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public partial class pageGIOHANG : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCart();
            }
        }

        public void LoadCart()
        {
            if (Session["CART"] != null)
            {
                CART cart = (CART)Session["CART"];
                this.grvCART.DataSource = cart.Listcarts.Values.ToList();
                this.grvCART.DataBind();
                this.grvCART.FooterRow.Cells[4].Text = "Tổng tiền =";
                this.grvCART.FooterRow.Cells[5].Text = cart.TotalBill().ToString();
            }
        }

        protected void btnDELETE_Click(object sender, EventArgs e)
        {
            CART cart = (CART)Session["CART"];
            foreach (GridViewRow row in grvCART.Rows)
            {
                CheckBox ckb = (CheckBox)row.FindControl("ckbREMOVEITEM");
                if (ckb.Checked)
                {
                    String masanpham = row.Cells[0].Text;
                    cart.RemoveCart(masanpham);
                }
            }
            Session["CART"] = cart;
            LoadCart();
        }

    }
}