using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{
    public GameObject player;
    public GameObjectPool[] pools;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerDeath")
        {
            return;
        }
        if(Random.Range(0, 5) == 0)
        {
            GameObjectPool rPool = pools[Random.Range(1, 3)];

            collision.gameObject.SetActive(false);
            GameObject platform = rPool.GetInactiveGameObject();

            if (platform)
            {
                platform.gameObject.SetActive(true);
                platform.transform.position = new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (12 + Random.Range(0.2f, 1.0f)));
            }
        }
        else if (Random.Range(0, 20) == 0)
        {
            GameObjectPool rPool = pools[Random.Range(4, pools.Length)];

            collision.gameObject.SetActive(false);
            GameObject platform = rPool.GetInactiveGameObject();

            if (platform)
            {
                platform.gameObject.SetActive(true);
                platform.transform.position = new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (12 + Random.Range(0.2f, 1.0f)));
            }
        }
        else
        {
            GameObjectPool rPool = pools[0];

            collision.gameObject.SetActive(false);
            GameObject platform = rPool.GetInactiveGameObject();

            if (platform)
            {
                platform.gameObject.SetActive(true);
                platform.transform.position = new Vector2(Random.Range(-4f, 4f), player.transform.position.y + (12 + Random.Range(0.2f, 1.0f)));
            }
        }
    }

}
