using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto que colisiona con el trigger es una plataforma o un monstruo, se desactiva
        collision.gameObject.SetActive(false);
    }
}


