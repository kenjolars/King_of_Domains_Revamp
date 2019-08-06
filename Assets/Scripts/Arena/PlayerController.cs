using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public int playerNumber = 1;
    public float Health = 100;
    bool facingRight;
    bool grounded = false;
    float moveSpeed = 3;
    float jumpForce = 6;
    Rigidbody2D rigidBody;
    public GameObject healthbar;
    Slider hpBar;

    void Awake()
    {
        if (playerNumber == 1)
        {
            facingRight = true;
        }
        if (playerNumber == 2)
        {
            facingRight = false;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        rigidBody = GetComponent<Rigidbody2D>();
        hpBar = healthbar.GetComponent<Slider>();
        hpBar.maxValue = Health;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerNumber == 1)
        {
            if (grounded && (Input.GetKey(KeyCode.W)))
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            }
        }
        if (playerNumber == 2)
        {
            if (grounded && (Input.GetKey(KeyCode.UpArrow)))
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            }
        }
        hpBar.value = Health;


    }
    void FixedUpdate()
    {
        if (playerNumber == 1)
        {
            if (Input.GetKey(KeyCode.D))
            {
                transform.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                if (!facingRight)
                {
                    Flip();
                }
            }
            else if (Input.GetKey(KeyCode.A))
            {
                transform.transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
                if (facingRight)
                {
                    Flip();
                }
            }
        }
        if (playerNumber == 2)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
                if (!facingRight)
                {
                    Flip();
                }
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.transform.Translate(Vector2.right * -moveSpeed * Time.deltaTime);
                if (facingRight)
                {
                    Flip();
                }
            }
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}