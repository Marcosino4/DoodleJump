using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject player;
    public Vector3 actualPosition;

    private void Start()
    {
        actualPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Si la posición del jugador es mayor que la de la cámara, la cámara se mueve hacia arriba
        Vector3 targetPosition = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);

        if (actualPosition.y < targetPosition.y)
        {
            transform.position = targetPosition;
        }
    }
}
