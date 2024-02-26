using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // El objeto que colisiona se desactiva
        collision.gameObject.SetActive(false);
    }
}


