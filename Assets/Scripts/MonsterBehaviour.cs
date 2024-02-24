using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && !Controller.playerInstance.isDead)
        {
            collision.gameObject.SetActive(false);
            Controller.playerInstance.isDead = true;
        }
    }
}
