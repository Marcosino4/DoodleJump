using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
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
        // Si el player no está muerto se le añade una fuerza hacia arriba
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }
}
