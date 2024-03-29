using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    private Camera camera;
    void Start()
    {
        camera = Camera.main;
    }

    void FixedUpdate()
    {
        Vector3 viewportPosition = camera.WorldToViewportPoint(transform.position);

        if (viewportPosition.y < -0.5)
        {
            gameObject.SetActive(false);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto que colisiona con el trigger tiene el tag "Player", se muere el jugador
        if (collision.gameObject.tag == "Player" && !Controller.playerInstance.godMode)
        {
            collision.gameObject.SetActive(false);
            CanvasManager.instance.DeathMenu();


        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
        else if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 550);
            gameObject.SetActive(false);
        }
    }
}
