using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Personas
{
    class Personas
    {
        //campos y propiedades 
        //Privados para cumplir con el encapsulado
        String dpi;
        String nombre;
        String apellido;
        //camel case
        DateTime FecNac;

        //encapsulado
        public string Dpi { get => dpi; set => dpi = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FecNac1 { get => FecNac; set => FecNac = value; }

        //metodos: acciones que se realizan

        public Personas()
        {
            dpi = "";
            nombre = "";
            apellido = "";

            //incializar  con la fecha de hoy 
            FecNac = DateTime.Now;
        }
         public void PrimeraMayuscula() 
        {
            if(nombre.Length > 0)
            { 
            System.Text.StringBuilder nombreMayuscula = new System.Text.StringBuilder(nombre);
            nombreMayuscula[0] = char.ToUpper(nombreMayuscula[0]);
            nombre = nombreMayuscula.ToString();
            }
            if (apellido.Length > 0)
            {
                StringBuilder apellidoMayuscula = new StringBuilder(apellido);
                apellidoMayuscula[0] = char.ToUpper(apellidoMayuscula[0]);
                apellido= apellidoMayuscula.ToString();

            }
        }
        public int edad()
        {
            //Calcular edad
            //fecha de nacimiento
            int mes = FecNac.Month;
            int years = FecNac.Year;
            DateTime actualidad = DateTime.Now;
            int month = actualidad.Month;
            int year = actualidad.Year;
            int res, resultado;
            if (mes > month)
            {
                year -= 1;
                month += 12;
                res = month - mes;
            }
            resultado = year - years;
            return resultado;
        }

        public void normalizar()
        {
            //Borra los espacios
            nombre = nombre.Trim();
            apellido = apellido.Trim();
            //Iniciamos un stringbuilder para recorrer toda la cadena para verificar si hay un caracter en ella
            // NOMBRE
            StringBuilder sincaracteres = new StringBuilder();
            for (int i = 0; i < nombre.Length; i++)
            {
                char cadena = nombre[i];
                //La funcion "char.IsLetter"
                if (char.IsLetter(cadena))
                {
                    //lo que hace aca es que si encuentra un caracter, lo borra y reescribe de nuevo la cadena
                    sincaracteres.Append(cadena);

                }

            }
            nombre = sincaracteres.ToString();

            //APELLIDO (LO MISMO)

            StringBuilder sincaracteresp = new StringBuilder();
            for (int i = 0; i < apellido.Length; i++)
            {
                char cadena1 = apellido[i];

                if (char.IsLetter(cadena1))
                {

                    sincaracteresp.Append(cadena1);

                }

            }
            apellido = sincaracteresp.ToString();

            //Aplicar mayusculas y minusculas automaticas:
            // usamos la libreria "CultureInfo.CurrentCulture" que basicamente proporciona  informacion de una region, idioma, etc
            // "ToTitleCase(sincaracteres" lo que hace es tomar la cadena de arriba  y devuelve una nueva pero donde la primera letra es mayuscula.
            nombre = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sincaracteres.ToString().ToLower());
            apellido = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(sincaracteresp.ToString().ToLower());
        }

    }

}
