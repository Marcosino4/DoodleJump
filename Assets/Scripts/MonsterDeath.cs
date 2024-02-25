using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public GameObject monster;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Si el objeto que colisiona con el trigger tiene el tag "Player", se le añade una fuerza hacia arriba y se desactiva el monstruo
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 550);
            monster.SetActive(false);
        }
    }
}
