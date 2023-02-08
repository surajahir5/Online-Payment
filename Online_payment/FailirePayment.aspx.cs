using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_payment
{
    public partial class FailirePayment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Transcation ID :" + Request.Form["txnid"] + " has been Failed";
        }
    }
}