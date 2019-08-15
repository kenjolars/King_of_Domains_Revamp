using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArenaManager : MonoBehaviour
{
    public Transform[] playerSpawnPoints;
    public GameObject[] characterPrefabs;

    public GameObject Player1;
    public GameObject Player2;
    public GameObject P1IsKilled;
    public GameObject P2IsKilled;

    private int P1ScoreCount;
    private int P2ScoreCount;
    public Text P1Score;
    public Text P2Score;
    public GameObject P1WinScreen;
    public GameObject P2WinScreen;

    //test
    public bool PlayerOneIsDead;
    public bool PlayerTwoIsDead;

    public GameObject[] Characters1;
    public Transform PlayerSpawnPoint1;
    public GameObject[] Characters2;
    public Transform PlayerSpawnPoint2;

    // Start is called before the first frame update
    void Start()
    {
        P1ScoreCount = 0;
        P2ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Player1 = GameObject.Find("Player One Controller");
        Player2 = GameObject.Find("Player Two Controller");

        P1IsKilled = GameObject.Find("P1IsKilled");
        P2IsKilled = GameObject.Find("P2IsKilled");

        //happens on player death
        if (P1IsKilled.activeInHierarchy)
        {
            Time.timeScale = 0f;
            P2ScoreCount = P2ScoreCount + 1;
            P2WinScreen.SetActive(true);

            PlayerOneIsDead = true;
        }


        if (P2IsKilled.activeInHierarchy)
        {
            Time.timeScale = 0f;
            P1ScoreCount = P1ScoreCount + 1;
            P1WinScreen.SetActive(true);

            PlayerTwoIsDead = true;
        }

        //reloading after player death
        if (P2WinScreen.activeInHierarchy == true && Input.GetKey(KeyCode.Y))
        {
            Time.timeScale = 1f;
            P2WinScreen.SetActive(false);
        }
        if (P2WinScreen.activeInHierarchy == true && Input.GetKey(KeyCode.N))
        {
            Application.LoadLevel("1 Menu");
        }
        if (P1WinScreen.activeInHierarchy == true && Input.GetKey(KeyCode.Y))
        {
            Time.timeScale = 1f;
            P1WinScreen.SetActive(false);
        }
        if (P1WinScreen.activeInHierarchy == true && Input.GetKey(KeyCode.N))
        {
            Application.LoadLevel("1 Menu");
        }
    }

    //Making sure the score is accurately displayed
    void P1ScoreText()
    {
        P1Score.text = "Score: " + P1ScoreCount;
    }
    void P2ScoreText()
    {
        P2Score.text = "Score: " + P2ScoreCount;
    }

    //Assigning Players
    void FindPlayer1()
    {
        
    }
}
