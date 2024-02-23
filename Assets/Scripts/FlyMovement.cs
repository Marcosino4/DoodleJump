using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    public float speed = 1.5f;
    Vector3 newPosition;

    void Start()
    {
        PositionChange();
    }

    void PositionChange()
    {
        float initialY = transform.position.y;
        float initialX = transform.position.x;

        newPosition = new Vector2(initialX + Random.Range(-1.0f, 1.0f), initialY + Random.Range(-1.0f, 1.0f));
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, newPosition) < 1)
            PositionChange();

        transform.position = Vector3.Lerp(transform.position, newPosition, Time.deltaTime * speed);

    }

}
