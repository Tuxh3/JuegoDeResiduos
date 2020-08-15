using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour {

	// Load Scene 01 when start button is pressed
	public void StartGame()
	{
		SceneManager.LoadScene ("Scene01");
	}



}
