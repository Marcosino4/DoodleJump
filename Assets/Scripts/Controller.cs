using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public static Controller playerInstance;
    private Rigidbody2D _rb;
    private float moveInput;
    private float speed = 10f;

    private bool isStarted = false;
    private float topScore = 0.0f;

    public bool isDead = false;
    public Text scoreText;
    public Text startText;

    private void Awake()
    {
        if (!playerInstance)
        {
            playerInstance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Start()
    {

        _rb = GetComponent<Rigidbody2D>();

        _rb.gravityScale = 0;
        _rb.velocity = Vector3.zero;

    }

     void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && isStarted == false)
        {

            isStarted = true;
            startText.gameObject.SetActive(false);
            _rb.gravityScale = 5f;

        }

        if (isStarted == true)
        {

            if (moveInput < 0)
            {

                this.GetComponent<SpriteRenderer>().flipX = false;

            }
            else
            {

                this.GetComponent<SpriteRenderer>().flipX = true;

            }

            if (_rb.velocity.y > 0 && transform.position.y > topScore)
            {

                topScore = transform.position.y;

            }

            scoreText.text = Mathf.Round(topScore).ToString();
        }

    }

    void FixedUpdate()
    {

        if (isStarted == true)
        {

            moveInput = Input.GetAxis("Horizontal");
            _rb.velocity = new Vector2(moveInput * speed, _rb.velocity.y);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "MenuPlatform")
        {
            _rb.velocity = Vector3.up * 600f;
        }

    }
}
