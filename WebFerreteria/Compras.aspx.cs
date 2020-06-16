using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFerreteria
{

    delegate double metodoMatematica(double A, double B);

    public partial class Compras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                List<Frutas> aux = (List<Frutas>)Session["ListadoFrutas"]; //Castear un dato "Convertir un dato"

                foreach (Frutas item in aux)
                {
                    listaFrutasVender.InnerHtml += "<li>" + item.nomFruta + "</li>";
                }
           }

            

        }

        protected void btnDato_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Session["Usuario"].ToString(); //Convertir un dato
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            //metodoMatematica fnSumar = Gestor.sumarNumeros;
            //double numero1 = Convert.ToDouble(txtNum1.Text);
            //double numero2 = Convert.ToDouble(txtNum2.Text);
            //double Resultado = fnSumar(numero1, numero2);
            //txtNum3.Text = Resultado.ToString();

            //Func - Action
            Func<double, double, double> fn1 = Gestor.sumarNumeros;
            double numero1 = Convert.ToDouble(txtNum1.Text);
            double numero2 = Convert.ToDouble(txtNum2.Text);
            double Resultado = fn1(numero1, numero2);
            txtNum3.Text = Resultado.ToString();

            Action<string> fn2 = Gestor.escribirBitacora;
            string guardar = String.Format("Se suman los numero {0} con {1} y da como resultado: {2}", numero1, numero2, Resultado);
            fn2(guardar);

            



        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}