using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication2.DataAcessLayer;
using WebApplication2.DataAcessLayer.Models;

namespace WebApplication2
{
    public partial class CustomerDetails : System.Web.UI.Page
    {
        public Customer moshtari;
        protected void Page_Load(object sender, EventArgs e)
        {

            long customerId =Convert.ToInt64(
                Page.Request.QueryString["customerId"]);

            DbContext dbContext = new DbContext();

            moshtari = dbContext.GetById(customerId);

        }
    }
}