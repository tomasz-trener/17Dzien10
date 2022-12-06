using P02AplikacjaZawodnicy.Domain;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy
{
    public partial class ZawodnicyAPI : System.Web.UI.Page
    {
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            Thread.Sleep(5000);


            string filtr = Request["filtr"];

            ZawodnicyRepository zr = new ZawodnicyRepository();

            Zawodnicy = zr.PodajZawodnikow(filtr).Zawodnicy;
        }
    }
}