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
    public float moveSpeed = 3;
    public float jumpForce = 6;
    Rigidbody2D rigidBody;
    public GameObject healthbar;
    Slider hpBar;

    public Transform[] playerSpawnPoints;
    public GameObject[] characterPrefabs;

    public GameObject AttackArea;
    public GameObject PlayerIsDead;

    public GameObject[] Characters1;
    public Transform PlayerSpawnPoint1;
    public GameObject[] Characters2;
    public Transform PlayerSpawnPoint2;

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
        AttackArea.SetActive(false);
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
        

        hpBar.value = Health;

        if (Health == 0)
        {
            PlayerIsDead.SetActive(true);
        }
        if (Health == 0 && (Input.GetKey(KeyCode.Y)))
        {
            Health = 100;
            PlayerIsDead.SetActive(false);
        }

        //Player Movement
        if (playerNumber == 1)
        {
            if (grounded && (Input.GetKey(KeyCode.W)))
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            }
            if (Input.GetKey(KeyCode.V))
            {
                AttackArea.SetActive(true);
            }
            else AttackArea.SetActive(false);

            PlayerIsDead.name = "P1IsKilled";
        }

        if (playerNumber == 2)
        {
            if (grounded && (Input.GetKey(KeyCode.UpArrow)))
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            }
            if (Input.GetKey(KeyCode.O))
            {
                AttackArea.SetActive(true);
            }
            else AttackArea.SetActive(false);

            PlayerIsDead.name = "P2IsKilled";
        }
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "AttackZone")
        {
            Health = Health - 10;
        }
    }
}