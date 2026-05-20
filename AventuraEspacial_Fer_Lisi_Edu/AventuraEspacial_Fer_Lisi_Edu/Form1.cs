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
using System.IO;

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

            string texto = "[" + DateTime.Now + "] " + 
                "Explorado: " + sistema.planetas[indice].Nombre + 
                " - Daño térmico: " + dano;
            File.AppendAllText("historial.txt", texto + Environment.NewLine);

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

        private void button2_Click(object sender, EventArgs e)
        {
            danoAcumulado = 0;
            naveExploto = false;
            lbDaño.Text = "Daño: 0";
            MessageBox.Show("🔧 La nave fue reparada exitosamente.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("historial.txt"))
            {
                string[] lineas =
                    File.ReadAllLines("historial.txt");

                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);
                }
            }
            else
            {
                MessageBox.Show(
                    "No existe historial todavía."
                );
            }
        }
    }
}
