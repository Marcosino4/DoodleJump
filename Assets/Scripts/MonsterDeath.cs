using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDeath : MonoBehaviour
{
    public GameObject monster;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 550);
            monster.SetActive(false);
        }
    }
}
