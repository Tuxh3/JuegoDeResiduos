using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitarPuntos : MonoBehaviour
{
    public int dañoResiduo = 10;

    GameObject Player;
    Vida playerVida;

     private void Awake()
    {
        Player = GameObject.FindWithTag("recoger");
        playerVida = Player.GetComponent<Vida>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag ("recoger"))
        {
            playerVida.TakeDaño(dañoResiduo);
        }
    }
}
