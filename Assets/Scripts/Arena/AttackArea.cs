using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    private float TimeBetweenAttacks;
    public float StartTimeBetweenAttacks;

    public Transform attackPos;
    public float attackRange;
    public LayerMask WhatIsEnemies;
    public int enemyhealth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeBetweenAttacks <= 0)
        {
            //Then you can attack
            if (Input.GetKey(KeyCode.V))
            {
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, WhatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    //enemiesToDamage[i].GetComponent<PlayerController>().Health(enemyhealth);
                }
            }


            TimeBetweenAttacks = StartTimeBetweenAttacks;
        }
        else
            {
                TimeBetweenAttacks -= Time.deltaTime;
            }
        }
}
