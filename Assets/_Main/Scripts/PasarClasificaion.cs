using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PasarClasificaion : MonoBehaviour
{
    public Button boton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     // Method loads next level depending on current scenes build index
	void LoadNextLevel()
	{
		SceneManager.LoadScene ("Clasificacion");
	}
}
