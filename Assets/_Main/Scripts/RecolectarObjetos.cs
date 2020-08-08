using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecolectarObjetos : MonoBehaviour
{
    public int TotalObjetos;
    public int ObjetosActuales;
    public Text Texto;

    // Start is called before the first frame update
    void Start()
    {
        ObjetosActuales = 0;
        TotalObjetos = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (ObjetosActuales != TotalObjetos)
        {
            Texto.text = ObjetosActuales.ToString() + "/" + TotalObjetos;             
        } else
        {
            Texto.text = "Felicidades, Terminaste el juego";
        }
    }

     void OnTriggerStay(Collider otro){
      if (otro.tag == "recoger" && Input.GetKey("q")){
          ObjetosActuales += 1;
       //cont = cont + 1;
       //print(cont);
       Destroy(otro.gameObject);

       }
   }
}
