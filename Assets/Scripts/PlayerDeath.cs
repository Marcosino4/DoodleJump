using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    public GameObject destroyer;
    public GameObject player;

    void Start()
    {
        gameObject.SetActive(true);
    }
    void Update()
    {
        if (player.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0f)
        {
            this.transform.position = new Vector2(transform.position.x, destroyer.transform.position.y - 150f);
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.SetActive(false);
            Controller.playerInstance.isDead = true;
        }
    }
}
