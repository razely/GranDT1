using System;
using System.Collections.Generic;
using Proyecto.Core.Models;

namespace Proyecto.Core.Repos
{
    public class JugadorRepo
    {
        private List<Jugador> _jugadores = new List<Jugador>
        {
            new Jugador 
            { 
                IdJugador = 1, 
                IdEquipo = 1, 
                Nombre = "Edinson", 
                Apellido = "Cavani", 
                Apodo = "El Matador", 
                FechaNacimiento = new DateTime(1987, 2, 14), 
                Cotizacion = 7.5m, 
                Posicion = "Delantero" 
            },
            new Jugador 
            { 
                IdJugador = 2, 
                IdEquipo = 2, 
                Nombre = "Franco", 
                Apellido = "Armani", 
                Apodo = "El Pulpo", 
                FechaNacimiento = new DateTime(1986, 10, 16), 
                Cotizacion = 6.0m, 
                Posicion = "Arquero" 
            }
        };

        public List<Jugador> ObtenerTodos()
        {
            return _jugadores;
        }

        public Jugador? ObtenerPorId(int idJugador)
        {
            foreach (Jugador jugador in _jugadores)
            {
                if (jugador.IdJugador == idJugador)
                {
                    return jugador;
                }
            }
            return null;
        }

        public List<Jugador> ObtenerPorEquipo(int idEquipo)
        {
            List<Jugador> resultado = new List<Jugador>();
            foreach (Jugador jugador in _jugadores)
            {
                if (jugador.IdEquipo == idEquipo)
                {
                    resultado.Add(jugador);
                }
            }
            return resultado;
        }

        public void Agregar(Jugador jugador)
        {
            _jugadores.Add(jugador);
        }
    }
}