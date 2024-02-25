using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject player;

    void Start()
    {
        gameObject.SetActive(true);
    }
    void FixedUpdate()
    {
        // Mueve el area de muerte del jugador hacia arriba si el jugador est� subiendo
        if (player.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            transform.position = new Vector2(transform.position.x, player.transform.position.y - 870f);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        // Si el jugador colisiona con el trigger, se activa la acci�n de muerte
        if (collider.gameObject.tag == "Player")
        {
            Controller.playerInstance.isDead = true;
        }
    }
}
