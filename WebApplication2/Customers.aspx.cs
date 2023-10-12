using System;
using System.Collections.Generic;
using System.Data;
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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            DbContext dbContext = new DbContext();
            DataTable moshtariha = dbContext.SearchCustomers("");

            GridView1.DataSource = moshtariha;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            long customerId =
                Convert.ToInt64(GridView1.DataKeys[e.RowIndex].Value);

            DbContext context = new DbContext();

            context.DeleteCustomer(customerId);

            Page.Response.Redirect(Page.Request.RawUrl);
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Customer moshtari = new Customer();
            moshtari.FirstName = txt_firstname.Text;
            moshtari.LastName = txt_lastname.Text;
            moshtari.CodeMelli = txt_codemelli.Text;
            moshtari.Mobile = txt_mobile.Text;
            moshtari.Address = txt_address.Text;

            DbContext context = new DbContext();

            context.AddCustomer(moshtari);

            Page.Response.Redirect(Page.Request.RawUrl);
        }
    }
}