using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElfAnims : MonoBehaviour
{
        private Animator ElfAnim;

    // Start is called before the first frame update
    void Start()
    {
        ElfAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Walk
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            ElfAnim.SetTrigger("ElfWalking");
        //Jump
        if (Input.GetKey(KeyCode.W))
            ElfAnim.SetTrigger("ElfJumping");

        if (gameObject.name == "Player One Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.V))
                ElfAnim.SetTrigger("ElfAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.B))
                ElfAnim.SetTrigger("ElfAttacking2");
        }

        if (gameObject.name == "Player Two Controller")
        {
            //Attack One
            if (Input.GetKey(KeyCode.O))
                ElfAnim.SetTrigger("ElfAttacking1");
            //Attack Two
            if (Input.GetKey(KeyCode.P))
                ElfAnim.SetTrigger("ElfAttacking2");
        }
    }
}
