using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RecolectarObjetos : MonoBehaviour
{
    
    public int TotalObjetos;
    public int ObjetosActuales;
    public Text Texto;
    public Text Texto2;
    public Text Texto3;
    public Button boton;
    

    // Start is called before the first frame update
    void Start()
    {
        ObjetosActuales = 0;
        TotalObjetos = 7;
       //boton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjetosActuales != TotalObjetos)
        {
            Texto.text = ObjetosActuales.ToString() + "/" + TotalObjetos;  
           
        } else
        {
           // Destroy(Texto.gameObject);
            Texto2.text = "Felicidades, Terminaste";
            Texto3.text = "de recolectar residuos";
           // boton.gameObject.SetActive(true);
            Invoke ("LoadNextLevel", 1f);

            
        }
    }

     void OnTriggerStay(Collider otro){
      //if (otro.tag == "recoger" && Input.GetKey("q")){
      if (otro.tag == "recoger"){
          ObjetosActuales += 1;
       //cont = cont + 1;
       //print(cont);
       Destroy(otro.gameObject);

       }
   }
   void LoadNextLevel()
	{
		SceneManager.LoadScene ("Clasificacion");
	}

  
}
