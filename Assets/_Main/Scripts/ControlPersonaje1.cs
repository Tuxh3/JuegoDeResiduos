using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ControlPersonaje1 : MonoBehaviour
{
    //Se inicializan los valores de la velocidad del movimiento y de la rotación(se pueden setear sin problemas)
    public float velocidadMovimiento = 0.5f;
    public float velocidadRotación = 200.0f;
    private Animator anim;
    public float x,y;

    // Start is called before the first frame update
    void Start()
    {
        //Se obtiene la animación del personaje
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //Se obtienen los valores de posición horizontal y vertical del personaje
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        //Se disminuyen o se aumentan los valores de velocidad para la rotación y el movimiento del personaje, pudiendo ir más
        //rápido o más lento
        transform.Rotate(0,x*Time.deltaTime*velocidadRotación,0);
        transform.Translate(0,0,y*Time.deltaTime*velocidadMovimiento);

        //Se cambian los valores de x y y para que el personaje se mueva a través del mapa
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }
}
