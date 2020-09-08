using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControlScript : MonoBehaviour {

	// Se obtienen los objetos que tienen las referencias de toEnable y toDisable 
	GameObject[] toEnable, toDisable;
	public Text Texto;

	// Objetos que hacen referencia a las preguntas, para saber cuál es la respuesta correcta y cual la incorrecta
	// a la hora de calsificar los residuos 
	public GameObject correctSign, incorrectSign;

	// Escena actual
	int currentSceneIndex;
	
	// Inicialización
	void Start () {

		// Inicialización de la escena
		currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

		// Se seleccionan los objetos con el tag toEnable y toDisable 
		toEnable = GameObject.FindGameObjectsWithTag ("ToEnable");
		toDisable = GameObject.FindGameObjectsWithTag ("ToDisable");

		// Desabilita los elementos que tienen el tag toEnable
		foreach (GameObject element in toEnable)
		{
			element.gameObject.SetActive (false);
		}

	}

	// Este método se invoca cuando la respuesta es correcta, si la respuesta es correcta se sigue a la siguiente pregunta con 
	// el residuo siguiente
	public void RightAnswer()
	{
		
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		
		correctSign.gameObject.SetActive (true);
		Invoke ("LoadNextLevel", 1f);


		
	}

	// Este método se invoca cuando la respuesta es incorrecta, si la respuesta está errada se le da una retroalimentación
	// al jugar y vuelve a iniciar la clasificación
	public void WrongAnswer()
	{
		// Desabilita los objetos que no se necesitan
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		incorrectSign.SetActive (true);
		int cont =1;
		if (cont == 1)
		{
			Texto.text = "Recuerda que los residuos como plástico, cartón, vidrio se ubican en la caneca de aprovechables; los restos de comida en la caneca de orgánicos y por último el papel, servilletas, cartón contaminado en la caneca no aprovechables";
		}
		
		

		// Retorna al inicio después de 12 segundos
		Invoke ("GotoMainMenu", 12f);
	}

	// Carga el siguiente nivel o escena
	void LoadNextLevel()
	{
		SceneManager.LoadScene (currentSceneIndex + 1);
	}

	// Carga la escena principal del cuestionario para la clasificación de los residuos
	void GotoMainMenu()
	{
		SceneManager.LoadScene ("Clasificacion");
	}

}
