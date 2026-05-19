using System;

namespace AventuraEspacial
{
    public struct Planeta
    {
        public string Nombre;
        public float Temperatura;
        public bool TieneOxigeno;
    }

    public class PlanetaSistema
    {
        public Planeta[] planetas = new Planeta[5];

        public void InicializarPlanetas()
        {
            planetas[0].Nombre = "Marte";
            planetas[0].Temperatura = 2.5f;
            planetas[0].TieneOxigeno = false;

            planetas[1].Nombre = "Kepler-22b";
            planetas[1].Temperatura = 4.2f;
            planetas[1].TieneOxigeno = true;

            planetas[2].Nombre = "Venus";
            planetas[2].Temperatura = 5.5f;
            planetas[2].TieneOxigeno = false;

            planetas[3].Nombre = "Jupiter";
            planetas[3].Temperatura = 1.8f;
            planetas[3].TieneOxigeno = false;

            planetas[4].Nombre = "Pandora";
            planetas[4].Temperatura = 3.1f;
            planetas[4].TieneOxigeno = true;
        }

        public unsafe void CalcularDano(float temperatura, float* dano)
        {
            *dano = temperatura * 100;
        }

        public string ExplorarPlaneta(int indice, ref float danoAcumulado)
        {
            float dano = 0;

            unsafe
            {
                CalcularDano(planetas[indice].Temperatura, &dano);
            }

            danoAcumulado += dano;

            return "Planeta: " + planetas[indice].Nombre +
       " | Temperatura: " + planetas[indice].Temperatura +
       " | Oxígeno: " + planetas[indice].TieneOxigeno +
       " | Daño: " + dano;
        }
    }
}