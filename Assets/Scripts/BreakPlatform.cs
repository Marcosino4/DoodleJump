using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlatform : MonoBehaviour
{
    private Camera camera;
    private Animator _animator;
    private void Start()
    {
        _animator = GetComponent<Animator>();
        camera = Camera.main;
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            this.StartCoroutine(this.Break());
        }
    }
    void FixedUpdate()
    {
        Vector3 viewportPosition = camera.WorldToViewportPoint(transform.position);

        if (viewportPosition.y < -1.005)
        {
            gameObject.SetActive(false);
        }
    }
    private IEnumerator Break()
    {
        _animator.SetBool("BreakPlatform", true);
        yield return new WaitForSecondsRealtime(0.5f);
        gameObject.SetActive(false);
    }
}
