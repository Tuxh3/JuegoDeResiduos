using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor.SceneManagement;


namespace Tests.Personaje
{
    public class Pruebas
    {
        private GameObject jugador;
        private GameObject suelo;
        private GameObject pared;


       [SetUp]
       public void SetUp (){
           EditorSceneManager.LoadScene("CASA");
           

       }

        [UnityTest]
        public IEnumerator PersonajeNoPasaSuelo()
        {
           yield return null;
           jugador = UnityEngine.GameObject.Find("Player");
           suelo = UnityEngine.GameObject.Find("Terrain");

           Assert.That(jugador.transform.position.y >= suelo.transform.position.y);

        }

         [UnityTest]
        public IEnumerator PersonajeNoPasaParedes()
        {
           yield return null;
           jugador = UnityEngine.GameObject.Find("Player");
           pared = UnityEngine.GameObject.Find("wall_18_107");

           Assert.That(jugador.transform.position.x >= pared.transform.position.x);

        }

        [TearDown]
        public void Teardown(){
            EditorSceneManager.UnloadSceneAsync("CASA");

        }




    }
}
