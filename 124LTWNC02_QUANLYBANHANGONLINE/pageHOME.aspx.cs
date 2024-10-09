using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public partial class pageHOME : System.Web.UI.Page
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU();
            String SQL = "SELECT ROW_NUMBER() OVER (ORDER BY MADANHMUC) AS AUTOINCREMENT, TENDANHMUC, MADANHMUC FROM tbDANHMUC";
            this.Repeater_DANHMUC.DataSource = xuly.getTable(SQL);
            this.Repeater_DANHMUC.DataBind();

            SQL = "select * from tbSANPHAM";

            String MADM = Request.QueryString.Get("MADANHMUC");
            if (MADM != null)
            {
                SQL = "select * from tbSANPHAM where MADANHMUC = " + MADM;
            }

            this.DataList_SANPHAM.DataSource = xuly.getTable(SQL);
            this.DataList_SANPHAM.RepeatColumns = 3;
            this.DataList_SANPHAM.DataBind();
        }
    }
}