using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletProperties : MonoBehaviour
{
    private Rigidbody2D rb;
    public float fuerzaDisparo;
    public float maxTime = 5f;
    private float timer;
    // Start is called before the first frame update

    private void Update()
    {
        if (timer > maxTime)
        {

            gameObject.SetActive(false);
            timer = 0;

        }
        timer += Time.deltaTime;
    }

    public void Shoot()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector3.up * fuerzaDisparo;
    }
}