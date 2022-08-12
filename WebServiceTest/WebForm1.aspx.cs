using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebServiceTest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        WSOnline.WebService1SoapClient WS = new WSOnline.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar(object sender, EventArgs e)
        {
            Label1.Text = WS.Suma(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
        }

        protected void btnResta(object sender, EventArgs e)
        {
            Label1.Text = WS.Resta(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();
        }

        protected void btnMultipl(object sender, EventArgs e)
        {
            Label1.Text = WS.Multiplicacion(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();

        }

        protected void btnDiv(object sender, EventArgs e)
        {
            Label1.Text = WS.Division(Convert.ToDouble(txtnum1.Text), Convert.ToDouble(txtnum2.Text)).ToString();

        }

        protected void ptnPoten(object sender, EventArgs e)
        {
            Label1.Text = WS.Potencia(Convert.ToDouble(txtnum1.Text), txtnum2.Text).ToString();

        }

        protected void btnRaiz(object sender, EventArgs e)
        {
            Label1.Text = WS.Raiz(Convert.ToDouble(txtnum1.Text)).ToString();

        }

        protected void btnSeno(object sender, EventArgs e)
        {
            Label1.Text = WS.Seno(Convert.ToDouble(txtnum1.Text)).ToString();

        }

        protected void btnCoseno(object sender, EventArgs e)
        {
            Label1.Text = WS.Coseno(Convert.ToDouble(txtnum1.Text)).ToString();
        }

        protected void btnTangente(object sender, EventArgs e)
        {
            Label1.Text = WS.Tangente(Convert.ToDouble(txtnum1.Text)).ToString();
        }

        protected void btnFactorial(object sender, EventArgs e)
        {
            Label1.Text = WS.Fact(Convert.ToInt32(txtnum1.Text)).ToString();
        }
    }
}