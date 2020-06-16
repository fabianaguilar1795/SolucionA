using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFerreteria
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Usuario"] = "Carlos Gonzalez Romero"; //aqui estoy creando una variable de sesion.

            List<Frutas> listadoFrutas = new List<Frutas>(); //inicializada una colección tipo lista de Frutas
            Frutas objFruta = new Frutas();
            objFruta.codFruta = "A100";
            objFruta.nomFruta = "Naranja";
            listadoFrutas.Add(objFruta);
            listadoFrutas.Add(new Frutas() { codFruta = "A200", nomFruta = "Melon" });
            listadoFrutas.Add(new Frutas() { codFruta = "A300", nomFruta = "Uva" });
            listadoFrutas.Add(new Frutas() { codFruta = "A400", nomFruta = "Manzana" });

            Session["ListadoFrutas"] = listadoFrutas;

            //Session.Remove("ListadoFrutas"); //borrar una variable de sesion.




        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Hola estudiantes otra ves";
        }

        protected void btnEjecutar2_Click(object sender, EventArgs e)
        {

        }
    }
}