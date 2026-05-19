using AventuraEspacial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AventuraEspacial_Fer_Lisi_Edu
{
    public partial class AventuraEspacial : Form
    {
        PlanetaSistema sistema = new PlanetaSistema();



        float danoAcumulado = 0;


        Random random = new Random();

        bool naveExploto = false;

        public AventuraEspacial()
        {
            InitializeComponent();

            sistema.InicializarPlanetas();
        }

        private void lbOxigeno_Click(object sender, EventArgs e)
        {

        }

        private void AventuraEspacial_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lbPlaneta_Click(object sender, EventArgs e)
        {

        }

        private void lbTemperatura_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = random.Next(0, sistema.planetas.Length);
            

            float dano = 0;

            if (naveExploto)
            {
                MessageBox.Show(
                    "🚫 La nave explotó.\n" +
                    "Repara tu nave para seguir explorando.",
                    "Nave destruida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            unsafe
            {
                sistema.CalcularDano(
                    sistema.planetas[indice].Temperatura,
                    &dano
                );
            }

            danoAcumulado += dano;

            lbPlaneta.Text = "Planeta: " +
                 sistema.planetas[indice].Nombre;

            lbTemperatura.Text = "Temperatura: " +
                sistema.planetas[indice].Temperatura;

            lbOxigeno.Text = "Oxígeno: " +
                (sistema.planetas[indice].TieneOxigeno ? "Sí" : "No");

            lbDaño.Text = "Daño: " +
                danoAcumulado;


            if (danoAcumulado > 500)
            {
                naveExploto = true;

                MessageBox.Show(
                    " ¡LA NAVE HA EXPLOTADO! 💥\n\n" +
                    "El daño térmico fue demasiado alto.\n" +
                    "La tripulación salió herida 🚀",
                    "ALERTA CRÍTICA",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }
    }
}
