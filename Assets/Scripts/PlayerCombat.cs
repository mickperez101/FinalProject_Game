using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    //Player Animation

    private Animator PLayeranimator;

    //Attack Points
    public Transform attackPoint;
    public Transform attackPoint2;
    public Transform attackPoint3;

    //Enemy Layer
    public LayerMask enemyLayers;

    //Attack Range and Damage
    public float AttackRange = 0.5f;
    public int attackDamage = 10;
    public int mediumDamage = 20;
    public int heavyDamage = 40;

    //Animator Function
    void Start()
    {
        PLayeranimator = GetComponent<Animator>();
    }

    // Allows the Attack to Function

    void Update()
    {
        AttackMovement();
    }



    //Function for Atttack Animations 

    void AttackMovement()
    {
        //Attack Animation 1 and Attack Point 1
        void Attack()
        {
            //plays attack animation
            PLayeranimator.SetTrigger("Attack");

            //Detect Enemies in Range of Attack and Damage
            Collider2D[] hitEnmies =  Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach(Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
            }


        }
        
        //creates the attack sphere
        void onDrawGizmosSelected()
        {
            if (attackPoint == null)
                return;
            Gizmos.DrawWireSphere(attackPoint.position, AttackRange);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Attack();
        } 

        //Attack 2 Animation and Attack Point 2
        void Attack2()
        {
            //plays second attack animation
            PLayeranimator.SetTrigger("Attack(2)");

            //Detect Enemy Range of Attack and Damage
            Collider2D[] hitEnmies = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(mediumDamage);
            }
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            Attack2();
        }

        //Attack Animation 3 and Attack Point 3
        void Attack3()
        {
            //Attack for 3rd Attack Animation
            PLayeranimator.SetTrigger("Attack(3)");

            //Detect Enemy in Range and Damage
            Collider2D[] hitEnmies = Physics2D.OverlapCircleAll(attackPoint.position, AttackRange, enemyLayers);

            foreach (Collider2D enemy in hitEnmies)
            {
                Debug.Log("We hit" + enemy.name);
                enemy.GetComponent<Enemy>().TakeDamage(heavyDamage);
            }
        }

        
        if (Input.GetKeyDown(KeyCode.X))
        {
            //plays third attack animation
            Attack3();
        }

       

    }
}
