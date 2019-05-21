using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palindrome
{
    public partial class Palindrome_Web : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            try
            {
                string userInput = TextBox1.Text;
                Palindrome test = new Palindrome();

                bool result = test.IsPalindrome(userInput);
                if (result == true)
                    Label1.Text = "Yes";
                else Label1.Text = "No";
            }
            catch (Exception ex)
            {
                Label1.Text = "Error occurred";
            }
        }
    }
    
}