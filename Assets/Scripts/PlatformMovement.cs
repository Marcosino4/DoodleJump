using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float velocidad = 4f;
    private float limiteIzquierdo;
    private float limiteDerecho;

    private int direccion = 1;

    void Start()
    {
        limiteIzquierdo = transform.position.x - 2f;
        limiteDerecho = transform.position.x + 2f;
    }
    void Update()
    {
        transform.Translate(Vector3.right * velocidad * direccion * Time.deltaTime);

        if (transform.position.x <= limiteIzquierdo)
        {
            CambiarDireccion(1);
        }
        else if (transform.position.x >= limiteDerecho)
        {
            CambiarDireccion(-1);
        }
    }

    void CambiarDireccion(int nuevaDireccion)
    {
        if (nuevaDireccion == -1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        direccion = nuevaDireccion;
    }
}
