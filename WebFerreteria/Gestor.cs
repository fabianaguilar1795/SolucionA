using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace WebFerreteria
{
    public class Gestor
    {

        
        public static double sumarNumeros(double n1, double n2)
        {
            return n1 + n2;
        }

        public static void escribirBitacora(string textoGuardar)
        {
            using (StreamWriter objStrem = new StreamWriter(@"C:\UIABitacora\bitacoraSistema.txt", true))
            {
                objStrem.WriteLine(textoGuardar);
                objStrem.Flush(); //Guardar en el archivo bitacoraSistema.txt
            }
            //El recurso llamado objStrem en esta linea ya no existe en memoria
        }

    }
}