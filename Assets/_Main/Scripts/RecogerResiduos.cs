using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerResiduos : MonoBehaviour
{
   public int cont = 0;
  

   

   


   void OnTriggerEnter2D(Collider2D otro){
      // if (otro.GetComponent<Collider2D>().tag == "recoger"){
       //cont = cont + 1;
       //print(cont);
       Destroy(gameObject);

     //  }
   }
}
