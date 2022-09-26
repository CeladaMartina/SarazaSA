using Negocio_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarazaSA
{
    public partial class Form1 : Form
    {
        Conexion conexion = new Conexion();       
        Random rand = new Random();
        Objetivo objetivo = new Objetivo();
        List<Arma> armas;      

        public Form1()
        {
            InitializeComponent();

            //carga las armas en el combo
            armas = new List<Arma>();
            armas.Add(new CañonCorto());
            armas.Add(new Ultrasonico());
            armas.Add(new Laser());

            this.cboArmas.DataSource = armas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexion.conectarBD();            
            objetivo.distancia = rand.Next(0, 200);
           
            LblObjetivo.Text = "El objetivo se encuenta a " + objetivo.distancia + " km de distancia.";
        }

        private void BtnDisparar_Click(object sender, EventArgs e)
        {
            Arma arma = (Arma)this.cboArmas.SelectedItem;
            string respuesta = arma.Disparar(objetivo);
            conexion.registrar(arma.GetType().Name, objetivo.distancia, respuesta);
            MessageBox.Show(respuesta);            
        }
        
    }
}
