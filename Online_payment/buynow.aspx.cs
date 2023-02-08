using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Online_payment
{
    public partial class buynow : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Request.QueryString["price"].ToString();  
            Random ran=new Random();
            txnid.Value = (Convert.ToString(ran.Next(10000, 20000)));
            txnid.Value = "suraj" + txnid.Value.ToString();
            Response.Write(txnid.Value.ToString());
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Double amount = Convert.ToDouble(Label2.Text);
            String text= key.Value.ToString() + "|" + txnid.Value.ToString() + "|" + amount + "|" + "cloths" + "|" + TextBox1.Text + "|" + TextBox2.Text + "|" + "1" + "1" + "1" + "1" + "1" + "||||||" + salt.Value.ToString();
            byte[] message = Encoding.UTF8.GetBytes(text);
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] hashValue;
            SHA512Managed hashString = new SHA512Managed();
            string hex = "";
            hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }

            hash.Value= hex;
            System.Collections.Hashtable data = new System.Collections.Hashtable();
            data.Add("hash", hex.ToString());
            data.Add("txnid", txnid.Value);
            data.Add("key", key.Value);
            data.Add("amount" , amount);
            data.Add("firstname", TextBox1.Text.Trim());
            data.Add("email", TextBox2.Text.Trim());
            data.Add("phone", TextBox3.Text.Trim());
            data.Add("productinfo", "clothes");
            data.Add("udf1", "1");
            data.Add("udf2", "1");
            data.Add("udf3", "1");
            data.Add("udf4", "1");
            data.Add("udf5", "1");
            data.Add("surl", "https://localhost:44348/SuccessPayment.aspx");
            data.Add("furl", "https://localhost:44348/FailirePayment.aspx");
            data.Add("service_provider", "");
            string strForm = PreparePOSTForm("https://test.payu.in/_payment", data);
            Page.Controls.Add(new LiteralControl(strForm));
        }

        private string PreparePOSTForm(string url, System.Collections.Hashtable data)
        {
            string fid = "PostForm";
            StringBuilder strForm = new StringBuilder();
            strForm.Append("<form id=\"" + fid + "\" name=\"" + fid + "\" action=\"" + url + "\" method=\"POST\">");
            foreach(System.Collections.DictionaryEntry key in data)
            {
                strForm.Append("<input type=\"hidden\" name=\"" + key.Key + "\" value=\"" + key.Value + "\">");
            }
            strForm.Append("</form>");
            StringBuilder strScript = new StringBuilder();
            strScript.Append("<script language='javaScript'>");
            strScript.Append("<script language='javascript'>");
            strScript.Append("var v " + fid + "=document." + fid + ";");
            strScript.Append("v" + fid + ".submit();");
            strScript.Append("</script>");
            return strForm.ToString() + strScript.ToString();
        }
    }
}