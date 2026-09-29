using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class PuntuacionRepo
    {
        private List<Puntuacion> _puntuaciones = new List<Puntuacion>
        {
            new Puntuacion { IdPuntuacion = 1, IdJugador = 1, NumFecha = 1, Nota = 8.5m },
            new Puntuacion { IdPuntuacion = 2, IdJugador = 2, NumFecha = 1, Nota = 7.0m }
        };

        public List<Puntuacion> ObtenerTodas()
        {
            return _puntuaciones;
        }

        public List<Puntuacion> ObtenerPorJugador(int idJugador)
        {
            List<Puntuacion> historial = new List<Puntuacion>();
            foreach (Puntuacion p in _puntuaciones)
            {
                if (p.IdJugador == idJugador)
                {
                    historial.Add(p);
                }
            }
            return historial;
        }

        public Puntuacion? ObtenerNotaDeFecha(int idJugador, int numFecha)
        {
            foreach (Puntuacion p in _puntuaciones)
            {
                if (p.IdJugador == idJugador && p.NumFecha == numFecha)
                {
                    return p;
                }
            }
            return null;
        }

        public void Agregar(Puntuacion puntuacion)
        {
            _puntuaciones.Add(puntuacion);
        }
    }
}