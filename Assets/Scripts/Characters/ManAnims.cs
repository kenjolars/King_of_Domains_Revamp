using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManAnims : MonoBehaviour
{
    private Animator ManAnim;

    // Start is called before the first frame update
    void Start()
    {
        ManAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            ManAnim.SetTrigger("ManWalking");
        //Jump
        if (Input.GetKey(KeyCode.W))
            ManAnim.SetTrigger("ManJumping");

        if (gameObject.name == "Player One Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.V))
                ManAnim.SetTrigger("ManAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.B))
                ManAnim.SetTrigger("ManAttacking2");
        }

        if (gameObject.name == "Player Two Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.O))
                ManAnim.SetTrigger("ManAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.P))
                ManAnim.SetTrigger("ManAttacking2");
        }
    }
}
