using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcAnims : MonoBehaviour
{
    private Animator OrcAnim;

    // Start is called before the first frame update
    void Start()
    {
        OrcAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            OrcAnim.SetTrigger("OrcWalking");
        //Jump
        if (Input.GetKey(KeyCode.W))
            OrcAnim.SetTrigger("OrcJumping");
        
        if(gameObject.name == "Player One Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.V))
                OrcAnim.SetTrigger("OrcAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.B))
                OrcAnim.SetTrigger("OrcAttacking2");
        }

        if (gameObject.name == "Player Two Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.O))
                OrcAnim.SetTrigger("OrcAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.P))
                OrcAnim.SetTrigger("OrcAttacking2");
        }
    }
}
