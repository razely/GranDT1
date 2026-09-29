using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class EquipoRepo
    {
        // simulación de la tabla Equipo con una lista en memoria
        private List<Equipo> _equipos = new List<Equipo>
        {
            new Equipo { IdEquipo= 1, Nombre = "Boca Juniors" },
            new Equipo { IdEquipo = 2, Nombre = "River Plate" },
            new Equipo { IdEquipo = 3, Nombre = "Racing Club" }
        };

        // obtener la lista completa de equipos
        public List<Equipo> ObtenerTodos()
        {
            return _equipos;
        }

        // buscar un equipo específico por su id
        public Equipo? ObtenerPorId(int id)
        {
            foreach (Equipo equipo in _equipos)
            {
                if (equipo.IdEquipo == id)
                {
                    return equipo; // Lo encontró y lo devuelve
                }
            }
            return null; // Si no lo encuentra, devuelve nulo
        }

        // agregar un equipo nuevo
        public void Agregar(Equipo equipo)
        {
            _equipos.Add(equipo);
        }
    }
}