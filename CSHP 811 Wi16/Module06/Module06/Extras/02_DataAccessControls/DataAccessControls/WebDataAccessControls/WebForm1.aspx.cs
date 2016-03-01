using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebDataAccessControls
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected string CustomRegionField()
        {
            string strData = "";
            if (GridView1.SelectedRow == null)
            {
                strData = "No Row Selected";
            }
            else
            {
                GridViewRow objRowOfData = GridView1.SelectedRow;
                strData = objRowOfData.Cells[2].Text;
            }

            return strData;
            //Note that you must force a new post back to bind the 
            //data to the page, AFTER it is returned!
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ButtonForceDataBinding_Click(object sender, EventArgs e)
        {
            Page.DataBind();         
        }

        protected void ButtonRead_Click(object sender, EventArgs e)
        {
            Response.Write(DropDownList1.SelectedItem.Text.ToString());
            Response.Write("<br />");
            Response.Write(ListBox1.SelectedItem.Value.ToString());
            Response.Write("<hr />");
        }

    }
}