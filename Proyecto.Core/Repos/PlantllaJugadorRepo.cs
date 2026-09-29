using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PlantillaJugadorRepo
    {
        private List<PlantillaJugador> _plantillaJugadores = new List<PlantillaJugador>();

        public List<PlantillaJugador> ObtenerTodos()
        {
            return _plantillaJugadores;
        }

        public List<PlantillaJugador> ObtenerPorPlantilla(int idPlantilla)
        {
            List<PlantillaJugador> resultado = new List<PlantillaJugador>();
            foreach (PlantillaJugador pj in _plantillaJugadores)
            {
                if (pj.IdPlantilla == idPlantilla)
                {
                    resultado.Add(pj);
                }
            }
            return resultado;
        }

        public void Agregar(PlantillaJugador plantillaJugador)
        {
            _plantillaJugadores.Add(plantillaJugador);
        }
    }
}