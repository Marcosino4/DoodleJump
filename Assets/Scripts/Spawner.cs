using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 actualPos;
    public GameObjectPool[] pools;

    private void Start()
    {
        actualPos.y = transform.position.y;
    }
    void FixedUpdate()
    {
        // Si la posición en Y del spawner es mayor o igual a la posición en Y actual más 2, se actualiza la posición en Y actual y se spawnean plataformas
        if (transform.position.y >= actualPos.y + 3.5f)
        {
            actualPos.y = transform.position.y;
            SpawnPlatform(Random.Range(1, 3));
        }
    }

    private void SpawnPlatform(int i)
    {
        int positionY;
        for (int j = 0; j < i; j++)
        {
            // Establece la posición en Y de la plataforma de forma aleatoria
            positionY = Random.Range(0, 3);

            // Spawnea una plataforma especial de forma aleatoria
            if (Random.Range(0, 20) == 0)
            {
                GameObjectPool rPool = pools[Random.Range(1, 5)];
                GameObject platform = rPool.GetInactiveGameObject();

                if (platform)
                {
                    platform.gameObject.SetActive(true);
                    platform.transform.position = new Vector2(Random.Range(-4.2f, 4.2f), this.transform.position.y + positionY);
                }
            }
            // Spawnea un monstruo de forma aleatoria
            else if (Random.Range(0, 60) == 0)
            {
                GameObjectPool rPool = pools[Random.Range(6, 13)];
                GameObject platform = rPool.GetInactiveGameObject();

                if (platform)
                {
                    platform.gameObject.SetActive(true);
                    platform.transform.position = new Vector2(Random.Range(-4.2f, 4.2f), this.transform.position.y + positionY);
                }
            }
            // Spawnea una plataforma normal
            else
            {
                GameObjectPool rPool = pools[0];
                GameObject platform = rPool.GetInactiveGameObject();

                if (platform)
                {
                    platform.gameObject.SetActive(true);
                    platform.transform.position = new Vector2(Random.Range(-4.2f, 4.2f), this.transform.position.y + positionY);
                }
            }

            // Spawnea un PowerUp de forma aleatoria
            if (Random.Range(0, 50) == 0)
            {
                GameObjectPool rPool = pools[Random.Range(14, pools.Length)];
                GameObject platform = rPool.GetInactiveGameObject();

                if (platform)
                {
                    platform.gameObject.SetActive(true);
                    platform.transform.position = new Vector2(Random.Range(-4.2f, 4.2f), this.transform.position.y + positionY);
                }
            }
        }
    }
}
