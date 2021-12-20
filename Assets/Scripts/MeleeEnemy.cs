using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeleeEnemy : MonoBehaviour
{
    //Variables for Enemy Attacks
    [SerializeField] private float attackCoolDown;
    [SerializeField] private float range;
    [SerializeField] private float collidarDistance;
    [SerializeField] private float damage;
    [SerializeField] private BoxCollider2D boxCollidar;
    [SerializeField] private LayerMask playerLayer;
    private float cooldownTimer = Mathf.Infinity;

    //References
    private Player playerhealth;

    //Enemy Animation for Attack
    private Animator animator;

    //Gets Enemy Animator
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    //Updates per frame
    void Update()
    {
        cooldownTimer += Time.deltaTime;

        if (PlayerinSight())
        {
            if (cooldownTimer > attackCoolDown)
            {
                cooldownTimer = 0;
                EnemyAttack();
            }
        }
    }

    void EnemyAttack()
    {
        animator.SetTrigger("Melee");
    }

    //Enemy notices Player
    private bool PlayerinSight ()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollidar.bounds.center + transform.right * range * transform.localScale.x * collidarDistance,boxCollidar.bounds.size,0,Vector2.left,0,playerLayer);

        if (hit.collider != null)
            playerhealth = hit.transform.GetComponent<Player>();

        return hit.collider !=null;
    }

    //Creates Attack Area
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;

        Gizmos.DrawWireCube(boxCollidar.bounds.center + transform.right * range * transform.localScale.x * collidarDistance,boxCollidar.bounds.size);

        //Gizmos.DrawWireSphere(attackPoint.position, AttackRange);
    }

    private void DamagePlayer()
    {
        if (PlayerinSight())
            playerhealth.TakeDamage(damage);
    }
}
