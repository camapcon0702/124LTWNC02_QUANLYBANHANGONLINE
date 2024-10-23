using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _124LTWNC02_QUANLYBANHANGONLINE
{
    public partial class pageViDu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbQUANLYBANHANGEntities db = new dbQUANLYBANHANGEntities();
            var tbsanpham = from tbSANPHAM in db.tbSANPHAM select tbSANPHAM;

            this.GridView1.DataSource = tbsanpham.ToList<tbSANPHAM>();
            this.GridView1.DataBind();
        }
    }
}