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
        Player = GameObject.FindWithTag("Player");
        playerVida = Player.GetComponent<Vida>();
        Debug.Log(Player);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerStay(Collider otro)   
    {
        Debug.Log(playerVida);
        if (otro.tag == "Player")
        {
            playerVida.TakeDaño(dañoResiduo);
        }
    }
}
