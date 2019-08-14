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

    private int P1ScoreCount;
    private int P2ScoreCount;
    public Text P1Score;
    public Text P2Score;
    public bool isPlayerAlive = true;
    public GameObject ContinueText;
    public GameObject P1WinText;
    public GameObject P2WinText;
    public GameObject P1AttackArea;
    public GameObject P2AttackArea;

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
        P1ScoreCount = 0;
        P2ScoreCount = 0;

        P1ScoreText();
        P2ScoreText();

        ContinueText.SetActive(false);
        P1WinText.SetActive(false);
        P2WinText.SetActive(false);

        P1AttackArea.SetActive(false);
        P2AttackArea.SetActive(false);
    }

    void P1ScoreText ()
    {
        P1Score.text = "Score: " + P1ScoreCount.ToString();
    }
    void P2ScoreText()
    {
        P2Score.text = "Score: " + P2ScoreCount.ToString();
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
            if (Input.GetKey(KeyCode.V))
            {
                P1AttackArea.SetActive(true);
            }
            else P1AttackArea.SetActive(false);


            if (isPlayerAlive == false && (Input.GetKey(KeyCode.Space) && P1ScoreCount < 2))
            {
                ContinueText.SetActive(false);
                Time.timeScale = 1f;
                Instantiate(Characters1[CharSelect.PlayerNum], PlayerSpawnPoint1.position, PlayerSpawnPoint1.rotation);
            }
        }
        if (playerNumber == 2)
        {
            if (grounded && (Input.GetKey(KeyCode.UpArrow)))
            {
                rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpForce);
            }
<<<<<<< HEAD
            if (Input.GetKey(KeyCode.O))
            {
                P2AttackArea.SetActive(true);
            }
            else P2AttackArea.SetActive(false);

            if (isPlayerAlive == false && (Input.GetKey(KeyCode.Space) && P2ScoreCount < 2))
            {
                ContinueText.SetActive(false);
                Time.timeScale = 1f;
                Instantiate(Characters1[CharSelect.PlayerNum], PlayerSpawnPoint2.position, PlayerSpawnPoint2.rotation);
            }
        }

=======
        }
>>>>>>> parent of 8930f22... Animations finalised
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
            if (Health == 0)
            {
                isPlayerAlive = false;
            }
            if (isPlayerAlive == false)
            {
                Time.timeScale = 0.1f;
                ContinueText.SetActive(true);
                P2ScoreCount = P2ScoreCount + 1;
                P2ScoreText();
            }
            else
            {
                ContinueText.SetActive(false);
            }
            if (P1ScoreCount == 3)
            {
                P1WinText.SetActive(true);
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
            if (Health == 0)
            {
                isPlayerAlive = false;
            }
            if (isPlayerAlive == false)
            {
                Time.timeScale = 0f;
                ContinueText.SetActive(true);
                P1ScoreCount = P2ScoreCount + 1;
                P1ScoreText();
            }
            else
            {
                ContinueText.SetActive(false);
            }
            if (P1ScoreCount == 3)
            {
                P2WinText.SetActive(true);
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