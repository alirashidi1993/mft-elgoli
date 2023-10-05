using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Home : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_adad_aval.Text) || string.IsNullOrEmpty(txt_adad_dovom.Text))
            {
                lbl_hasel.Text="0";
                return;
            }
            int adad_aval = Convert.ToInt32(txt_adad_aval.Text);
            int adad_dovom = Convert.ToInt32(txt_adad_dovom.Text);
            lbl_hasel.Text = (adad_aval+adad_dovom).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_adad_aval.Text) || string.IsNullOrEmpty(txt_adad_dovom.Text))
            {
                lbl_hasel.Text = "0";
                return;
            }
            int adad_aval = Convert.ToInt32(txt_adad_aval.Text);
            int adad_dovom = Convert.ToInt32(txt_adad_dovom.Text);
            lbl_hasel.Text = (adad_aval - adad_dovom).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txt_adad_aval.Text = "";
            txt_adad_dovom.Text = "";
        }
    }
}