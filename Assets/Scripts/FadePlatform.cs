using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePlatform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.gameObject.SetActive(false);
    }
}
