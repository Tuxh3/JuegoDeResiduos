using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelControlScript : MonoBehaviour {

	// Get references to game objects that should be disabled and enabled
	// at the start
	GameObject[] toEnable, toDisable;
	public Text Texto;

	// References to game objects that should be enabled
	// when correct or incorrect answer is given
	public GameObject correctSign, incorrectSign;

	// Variable to contain current scene build index
	int currentSceneIndex;

	// Variable name to pass to Player Prefs meaning which variable to set as got
	// Adjustable in inspector depending on current scene and trophy
	// you earn (if you do)
	
	// Use this for initialization
	void Start () {

		// Getting current scene build index
		currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;

		// Finding game objects with tags "ToEnable" and "ToDisable"
		toEnable = GameObject.FindGameObjectsWithTag ("ToEnable");
		toDisable = GameObject.FindGameObjectsWithTag ("ToDisable");

		// Disabling game objects with tag "ToEnable"
		foreach (GameObject element in toEnable)
		{
			element.gameObject.SetActive (false);
		}

	}

	// Method is invoked when correct answer is given
	public void RightAnswer()
	{
		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "correct" sign
		correctSign.gameObject.SetActive (true);
		Invoke ("LoadNextLevel", 1f);


		
	}

	// Method is invoked if incorrect answer is given
	public void WrongAnswer()
	{
		// Disabling game objects that are no longer needed
		foreach (GameObject element in toDisable)
		{
			element.gameObject.SetActive (false);
		}

		// Turn on "incorrect" sign
		incorrectSign.SetActive (true);
		int cont =1;
		if (cont == 1)
		{
			Texto.text = "Recuerda que los residuos como cáscara de bánano son clasificados como residuos no aprovechables y van en la caneca de color azul.";
		}
		
		

		// Invoke GotoMainMenu method in 7 second
		Invoke ("GotoMainMenu", 7f);
	}



	// Method loads next level depending on current scenes build index
	void LoadNextLevel()
	{
		SceneManager.LoadScene (currentSceneIndex + 1);
	}

	// Method loads MainMenu scene
	void GotoMainMenu()
	{
		SceneManager.LoadScene ("Clasificacion");
	}

}
