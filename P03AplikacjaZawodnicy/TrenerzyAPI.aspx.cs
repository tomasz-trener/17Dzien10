﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy
{
    public partial class TrenerzyAPI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idTreneraS = Request["idTrenera"];

            int id = Convert.ToInt32(idTreneraS);



            //txtImie.Text = 
        
        }
    }
}