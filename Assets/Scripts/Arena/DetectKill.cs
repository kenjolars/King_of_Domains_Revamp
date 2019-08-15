using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectKill : MonoBehaviour
{
    public GameObject PlayerOne;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerOne = GameObject.Find("Player One Controller");

        
    }
}
