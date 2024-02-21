using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadePlatform : MonoBehaviour
{
    private float fadeSpeed = 0.00001f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Color platColor = gameObject.GetComponent<Renderer>().material.color;

        while (platColor.a > 0)
        {
            float fadeAmount = platColor.a - (fadeSpeed * Time.deltaTime);

            platColor = new Color(platColor.r, platColor.g, platColor.b, fadeAmount);
            this.GetComponent<Renderer>().material.color = platColor;
        }
    }
}
