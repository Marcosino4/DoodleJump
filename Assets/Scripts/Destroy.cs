using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destroy : MonoBehaviour
{

    public Text text;
    public GameObject player;
    public GameObjectPool objPool;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name.StartsWith("Platform"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.SetActive(false);
                GameObject springPlatform = objPool.GetInactiveGameObject(GameObjectPool.instance.springPlatformPool);
                if (springPlatform)
                {
                    springPlatform.gameObject.SetActive(true);
                    springPlatform.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
                }

            } else
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }

        } else if(collision.gameObject.name.StartsWith("Spring"))
        {

            if (Random.Range(1, 7) == 1)
            {

                collision.gameObject.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));

            }
            else
            {
                collision.gameObject.SetActive(false);
                GameObject platform = objPool.GetInactiveGameObject(GameObjectPool.instance.platformPool);
                if (platform)
                {
                    platform.gameObject.SetActive(true);
                    platform.transform.position = new Vector2(Random.Range(-4.5f, 4.5f), player.transform.position.y + (14 + Random.Range(0.2f, 1.0f)));
                }
            }

        }
    }

}
