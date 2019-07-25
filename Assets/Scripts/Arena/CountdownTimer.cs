using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    //variables
    public float timeRemaining;
    Text timer;

    void Awake()
    {
        timer = gameObject.GetComponent<Text>();   
    }

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = 90;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            //do stuff

        }

        timer.text = timeRemaining.ToString("F0");
    }
}
