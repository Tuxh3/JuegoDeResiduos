using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public int vidaInicial = 10;
    public int vidaActual;
    public Slider barraSlider;

    
     private void Awake()
    {
        vidaActual = vidaInicial;
    }
    void Start()  
    {

    }

    

    // Update is called once per frame
    public void TakeDaño(int valorDaño)
    {
        vidaActual += valorDaño;
        barraSlider.value = vidaActual;
        print(barraSlider.value);

        if (vidaActual < 0)
        {
            Destroy(gameObject);
        }
    }
}
