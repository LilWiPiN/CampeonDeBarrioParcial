using CampeonDeBarrio;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DebeIdentificarCampeonEnPosicion0()
        {
            //Arrange
            //Se definen las variables del esceneario
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 3, Puntos = 400 },
                new Jugador { Nombre = "Bernardo", Campañas = 4, Puntos = 200 },
                new Jugador { Nombre = "Camila", Campañas = 5, Puntos = 300 },
                new Jugador { Nombre = "Diego", Campañas = 6, Puntos = 250 },
                new Jugador { Nombre = "Elena", Campañas = 4, Puntos = 240 }
            };

            //Forzamos a que el jugador campeon sea el primer jugador (Alicia)
            Jugador jugadorCampeon = arregloJugadores[0];

            //Definimos el resultado que esperamos tener
            float esperado = jugadorCampeon.Promedio;

            //Act
            //Definimos el resultado que se obtiene al ejecutar el programa
            float real = Program.IdentificaCampeon(arregloJugadores);

            //Assert
            //Comparamos si el resultado esperado concuerda con el obtenido al ejecutar el programa
            Assert.AreEqual(esperado, real);
        }

        [TestMethod]
        public void DebeIdentificarElCampeonConMayorPromedio()
        {
            //Arrange
            //Se definen las variables del caso
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 1, Puntos = 102 },
                new Jugador { Nombre = "Bernardo", Campañas = 4, Puntos = 200 },
                new Jugador { Nombre = "Camila", Campañas = 3, Puntos = 306 },
                new Jugador { Nombre = "Diego", Campañas = 2, Puntos = 400 },
                new Jugador { Nombre = "Elena", Campañas = 2, Puntos = 204 }
            };

            //Forzamos a que el jugador campeon sea el primer jugador (Alicia)
            Jugador jugadorCampeon = arregloJugadores[0];

            //Comparamos con el resto de jugadores
            for (int i = 1; i < arregloJugadores.Length; i++)
                //Si hay un jugador con mejor promedio, es el nuevo campeón
                if (jugadorCampeon.Promedio < arregloJugadores[i].Promedio)
                    jugadorCampeon = arregloJugadores[i];

            //Definimos el resultado que esperamos tener
            float esperado = jugadorCampeon.Promedio;

            //Act
            //Definimos el resultado que se obtiene al ejecutar el programa
            float real = Program.IdentificaCampeon(arregloJugadores);

            //Assert
            //Comparamos si el resultado esperado concuerda con el obtenido al ejecutar el programa
            Assert.AreEqual(esperado, real);
        }

        [TestMethod]
        public void DebeIdentificarEmpate()
        {
            //Arrange
            //Se dejinen las variables del caso
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 2, Puntos = 240 },
                new Jugador { Nombre = "Bernardo", Campañas = 4, Puntos = 200 },
                new Jugador { Nombre = "Camila", Campañas = 5, Puntos = 300 },
                new Jugador { Nombre = "Diego", Campañas = 3, Puntos = 360 },
                new Jugador { Nombre = "Elena", Campañas = 4, Puntos = 240 }
            };

            float campeon1 = 0;
            float campeon2 = 0;

            //Forzamos a que el jugador campeon sea el primer jugador (Alicia)
            Jugador jugadorCampeon = arregloJugadores[0];

            //Recorremos la lista de los jugadores para guardar a los campeones
            foreach (Jugador unJugador in arregloJugadores)
                if (unJugador.Promedio == jugadorCampeon.Promedio)
                {
                    campeon1 = jugadorCampeon.Promedio;
                    campeon2 = unJugador.Promedio;
                }

            //Definimos el resultado que esperamos tener
            float esperado1 = campeon1;
            float esperado2 = campeon2;

            //Act
            //Definimos el resultado que se obtiene al ejecutar el programa
            float real = Program.IdentificaCampeon(arregloJugadores);

            //Assert
            //Comparamos si el resultado esperado concuerda con el obtenido al ejecutar el programa
            Assert.AreEqual(esperado1, esperado2, real);
        }
    }
}


