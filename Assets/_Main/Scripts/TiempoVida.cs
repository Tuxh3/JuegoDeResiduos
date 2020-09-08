using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoVida : MonoBehaviour
{

    public float tiempodevida = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,tiempodevida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
