﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace SessionExample
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Session["Uid"]  =txtUid.Text;
       Response.Redirect("WebForm2.aspx");
        }
    }
       
        
    
}