using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject destroyer;

    void Update()
    {
        this.transform.position = new Vector2(transform.position.x, destroyer.transform.position.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Controller.playerInstance.isDead = true;
        }
    }
}
