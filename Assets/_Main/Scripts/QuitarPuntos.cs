using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuitarPuntos : MonoBehaviour
{
    // Hace referencia al puntaje que obtiene el jugador al recolectar algún residuo
    public int dañoResiduo = 10;

    // Instancia al jugador
    GameObject Player;
    // Instancia la barra de vida
    Vida playerVida;

    // Método que se invoca cuando el jugador entra en contacto o colisiona con los residuos empieza a aumentar el puntaje
    // y el contador de objetos por encontrar
     private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
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
        Debug.Log(playerVida);
        if (otro.tag == "Player")
        {
            playerVida.TakeDaño(dañoResiduo);
        }
    }
}
