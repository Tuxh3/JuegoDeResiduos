using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamaraJugador : MonoBehaviour
{
    public Vector3 offset; // distancia que hay entre la main camera y el jugador 
    private Transform target; //el jugador, lacamara va a seguir a el jugador 
    [Range(0, 1)]public float LerpValue; //nos muestra una barra para elegir entre 0 y 1 la velocidad de la camara
    public float sensibilidad;

    void Start()
    {
        target = GameObject.Find("Player").transform; //Busca el objeto Player dentro de la escena y 
                                                    //sacamos la posición en la que se encuentra
    }

    
    void LateUpdate() //función que se ejecuta al final, lo último que se va a ejecutar
    {
       //decimos la posicion de la camara, se toma la posición propia, la movemos a la del 
       //jugador y le damos la velocidad de la camara 
        transform.position = Vector3.Lerp(transform.position, target.position + offset, LerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up) * offset;
        transform.LookAt(target);
    } 
}
