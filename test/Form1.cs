using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtimagen.Focus();
        }

        private void btnocultar_Click(object sender, EventArgs e)
        {
            string numeroimagen = txtimagen.Text;

            switch (numeroimagen)
            {

                case "1":
                    pbimagen3.Visible = false;
                    break;

                case "2":
                    pbimagen4.Visible = false;
                    break;

                case "3":
                    pbimagen5.Visible = false;
                    break;

                case "4":
                    pbimagen2.Visible = false;
                    break;

                case "5":
                    pbimagen1.Visible = false;
                    break;

                default:
                    MessageBox.Show("Error: El valor ingresado es incorrecto, intentelo de nuevo.");
                    txtimagen.Text = "";
                    txtimagen.Focus();
                    break;

            }
            //Fuera de la llave del Switch se ejecuta la función.
            restablecercampo();


        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string numeroimagen = txtimagen.Text;

            switch (numeroimagen)
            {

                case "1":
                    pbimagen3.Visible = true;
                    break;

                case "2":
                    pbimagen4.Visible = true;
                    break;

                case "3":
                    pbimagen5.Visible = true;
                    break;

                case "4":
                    pbimagen2.Visible = true;
                    break;

                case "5":
                    pbimagen1.Visible = true;
                    break;

                default:
                    MessageBox.Show("Error: El valor ingresado es incorrecto, intentelo de nuevo.");
                    txtimagen.Text = "";
                    txtimagen.Focus();
                    break;

            }
            //Fuera de la llave del Switch se ejecuta la función.
            restablecercampo();
        }
        //Se crea la función dentro de la llave de "Class".
        private void restablecercampo()
        {
            txtimagen.Text = "";
            txtimagen.Focus();
        }

        private void pbimagen3_DoubleClick(object sender, EventArgs e)
        {
            pbimagen3.Visible = false;
            abrirurl("https://www.mcdonalds.com.co/");
        }

        private void pbimagen4_DoubleClick(object sender, EventArgs e)
        {
            pbimagen4.Visible = false;
            abrirurl("https://www.kfc.co/");
        }

        private void pbimagen5_DoubleClick(object sender, EventArgs e)
        {
            pbimagen5.Visible = false;
            abrirurl("https://www.postobon.com/contenido/mountain-dew");
        }

        private void pbimagen2_DoubleClick(object sender, EventArgs e)
        {
            pbimagen2.Visible = false;
            abrirurl("https://www.coca-cola.com.co/es/co/home/");
        }

        private void pbimagen1_Click(object sender, EventArgs e)
        {
            pbimagen1.Visible = false;
            abrirurl("https://www.pepsi.com/en-us/");
        }
        //Función para abrir la url de la imagen correspondiente.
        private void abrirurl(string pagina)
        {
            System.Diagnostics.Process.Start(pagina);
        }

        private void mostrartodos_Click(object sender, EventArgs e)
        {
            pbimagen1.Visible = true;
            pbimagen2.Visible = true;
            pbimagen3.Visible = true;
            pbimagen4.Visible = true;
            pbimagen5.Visible = true;
        }

        private void ocultartodo_Click(object sender, EventArgs e)
        {

            pbimagen1.Visible = false;
            pbimagen2.Visible = false;
            pbimagen3.Visible = false;
            pbimagen4.Visible = false;
            pbimagen5.Visible = false;

        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dar doble click para ir a la URL de el logo deseado.");
        }
    }
}
