using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el player no est� muerto se le a�ade una fuerza hacia arriba
        if (collision.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0 && !Controller.playerInstance.isDead)
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600f);
        }
    }
}
