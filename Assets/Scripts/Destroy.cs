using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{

    public Text text;
    public GameObject player;
    public GameObjectPool[] pools;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObjectPool rPool = pools[Random.Range(0, pools.Length)];

        collision.gameObject.SetActive(false);
        GameObject platform = rPool.GetInactiveGameObject();

        if (platform)
        {
            platform.gameObject.SetActive(true);
            platform.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (12 + Random.Range(0.2f, 1.0f)));
        }
    }

}
