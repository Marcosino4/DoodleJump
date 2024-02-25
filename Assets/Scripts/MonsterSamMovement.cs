using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSamMovement : MonoBehaviour
{
    public float velocidad = 5f;
    public float limiteIzquierdo = -4f;
    public float limiteDerecho = 4f;

    private int direccion = 1;

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
