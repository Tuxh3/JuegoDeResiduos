using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    private void OnTriggerStay(Collider otro)
    {
        if (otro.tag == "recoger")
        {
            playerVida.TakeDaño(dañoResiduo);
        }
    }
}
