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
    public partial class Customers : System.Web.UI.Page
    {
        public List<Customer> moshtariha;
        protected void Page_Load(object sender, EventArgs e)
        {
            DbContext dbContext = new DbContext();
            moshtariha= dbContext.SearchCustomers("");
            
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DbContext paygahDade = new DbContext();
            moshtariha= paygahDade.SearchCustomers(txt_search.Text);
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
        }
    }
}