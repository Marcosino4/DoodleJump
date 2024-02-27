using System.Collections;

using System.Collections.Generic;

using UnityEngine;



public class Shoot : MonoBehaviour
{
    public GameObject spawnPoint;
    public BulletObjectPool pool;
    public GameObject player;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GameObject bullet = pool.GetInactiveGameObject();
            if (bullet)
            {

                bullet.transform.position = spawnPoint.transform.position;
                bullet.SetActive(true);
                bullet.GetComponent<BulletProperties>().Shoot();
            }

        }
    }
}