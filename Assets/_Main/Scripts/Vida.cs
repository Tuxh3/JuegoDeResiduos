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

    

    // Se actualiza el puntaje del jugador y la cantidad de residuos que va recolectando
    public void TakeDaño(int valorDaño)
    {
        vidaActual += valorDaño;
        barraSlider.value = vidaActual;
        print(barraSlider.value);

        // Se elimina el residuo que se recolecta
        if (vidaActual < 0)
        {
            Destroy(gameObject);
        }
    }
}
