using System.Collections;
using System.Collections.Generic;
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

        if (viewportPosition.y < -1.005)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto que colisiona con el trigger tiene el tag "Player", se muere el jugador
        if (collision.gameObject.tag == "Player" && !Controller.playerInstance.godMode)
        {
            collision.gameObject.SetActive(false);
            CanvasManager.instance.DeathMenu();
        }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
    }
}
