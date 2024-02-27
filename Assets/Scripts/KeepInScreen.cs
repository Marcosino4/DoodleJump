using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInScreen : MonoBehaviour
{
    [SerializeField] private float pushValue;
    private Camera camera;

    void Start()
    {
        camera = Camera.main;
    }

    void Update()
    {
        Vector3 viewportPosition = camera.WorldToViewportPoint(transform.position);

        if(viewportPosition.x > 1) {
            transform.position = camera.ViewportToWorldPoint(
                new Vector3(pushValue, viewportPosition.y, viewportPosition.z));
        }
        else if (viewportPosition.x < 0)
        {
            transform.position = camera.ViewportToWorldPoint(
                new Vector3(1 - pushValue, viewportPosition.y, viewportPosition.z));
        }

        if (viewportPosition.y < 0)
        {
            CanvasManager.instance.DeathMenu();
        }
    }
}

