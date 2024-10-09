using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public partial class MASTERPAGEUSER : System.Web.UI.MasterPage
    {
        XULYDULIEU xuly;
        protected void Page_Load(object sender, EventArgs e)
        {
            xuly = new XULYDULIEU();
            String SQL = "SELECT ROW_NUMBER() OVER (ORDER BY TENDANHMUC) AS AUTOINCREMENT, TENDANHMUC, MADANHMUC FROM tbDANHMUC";
            this.Repeater_DANHMUC.DataSource = xuly.getTable(SQL);
            this.Repeater_DANHMUC.DataBind();
        }
    }
}