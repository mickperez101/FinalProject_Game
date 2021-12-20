/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldCode : MonoBehaviour
{
    // Start is called before the first frame update

    //Code for Melee Attack for Attack Points

    //public float AttackRange = 0.5f;
    //public Transform attackPoint;
    
    //Collider2D[] hitPlayer = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, playerLayer);

        
        foreach (Collider2D player in hitPlayer)
        {
            player.GetComponent<Player>().TakeDamage(damage);
            Debug.Log("We hit Player");
        }
    
    //Player Health
    void Start()
    {
        playerHealth = maxHealth;
        PlayerAnimator = GetComponent<Animator>();
    }

    
    //Left Attack Animation.

        
        void AttackL()
        {
            //plays attack animation
            PLayeranimator.SetTrigger("AttackLeft");

            //Detect Enemies in Range of Attack and Damage
            Collider2D[] hitEnmies = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }


        }


        if (Input.GetKeyDown(KeyCode.F) && Input.GetKey(KeyCode.LeftShift))
        {
            AttackL();
        }

        //Attack Two Left
        void Attack2L()
        {
            //plays second attack animation
            PLayeranimator.SetTrigger("Attack(2)L");

            //Detect Enemy Range of Attack and Damage
            Collider2D[] hitEnmies = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(mediumDamage);
            }
        }


        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.R))
        {
            Attack2L();
        }

        void Attack3L()
        {
            //Attack for 3rd Attack Animation
            PLayeranimator.SetTrigger("Attack(3)L");

            //Detect Enemy in Range and Damage
            Collider2D[] hitEnmies = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(heavyDamage);
            }
        }


        if (Input.GetKeyDown(KeyCode.C) && Input.GetKey(KeyCode.LeftShift))
        {
            //plays third attack animation
            Attack3L();
        }

       
    

}

*/