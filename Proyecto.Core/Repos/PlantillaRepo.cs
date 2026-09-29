using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PlantillaRepo
    {
        private List<Plantilla> _plantillas = new List<Plantilla>();

        public List<Plantilla> ObtenerTodas()
        {
            return _plantillas;
        }

        public Plantilla? ObtenerPorUsuario(int idUsuario)
        {
            foreach (Plantilla plantilla in _plantillas)
            {
                if (plantilla.IdUsuario == idUsuario)
                {
                    return plantilla;
                }
            }
            return null;
        }

        public void Agregar(Plantilla plantilla)
        {
            _plantillas.Add(plantilla);
        }
    }
}