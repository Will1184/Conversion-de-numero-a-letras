using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GM21057Guia8Ejercicio3
{
    internal class Numero
    {
        private string numeroLetra;
        
        public Numero()
        {
        }

        public Numero(string numeroLetra)
        {
            this.numeroLetra = numeroLetra;
        }

      
        public string NumeroLetra
        {
            get { return this.numeroLetra; }
            set { this.numeroLetra = value; }
        }
       
        public void LetrasNum(Numero numero,TextBox textBoxMostrar)
        {
            switch (numero.NumeroLetra.ToLower())
            {
                case "1":
                    textBoxMostrar.Text = "Uno";
                    break;
                case "2":
                    textBoxMostrar.Text = "Dos";
                    break;
                case "3":
                    textBoxMostrar.Text = "Tres";
                    break;
                case "4":
                    textBoxMostrar.Text = "Cuatro";
                    break;
                case "5":
                    textBoxMostrar.Text = "Cinco";
                    break;
                case "6":
                    textBoxMostrar.Text = "Seis";
                    break;
                case "7":
                    textBoxMostrar.Text = "Siete";
                    break;
                case "8":
                    textBoxMostrar.Text = "Ocho";
                    break;
                case "9":
                    textBoxMostrar.Text = "Nueve";
                    break;
                case "10":
                    textBoxMostrar.Text = "Diez";
                    break;
                case "uno":
                    textBoxMostrar.Text = "1";
                    break;
                case "dos":
                    textBoxMostrar.Text = "2";
                    break;
                case "tres":
                    textBoxMostrar.Text = "3";
                    break;
                case "cuatro":
                    textBoxMostrar.Text = "4";
                    break;
                case "cinco":
                    textBoxMostrar.Text = "5";
                    break;
                case "seis":
                    textBoxMostrar.Text = "6";
                    break;
                case "siete":
                    textBoxMostrar.Text = "7";
                    break;
                case "ocho":
                    textBoxMostrar.Text = "8";
                    break;
                case "nueve":
                    textBoxMostrar.Text = "9";
                    break;
                case "diez":
                    textBoxMostrar.Text = "10";
                    break;

                default:
                    MessageBox.Show("Se ingreso valores no permitidos","Error"); 
                    break;
            }
        }
    }
}
