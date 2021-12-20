using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBarb : MonoBehaviour
{
    //Enemy Animation - Death
    public Animator EnemyAnimator;

    //Health Bar
    public GameObject healthBar;
    public Slider healthBarSlider;

    //Health
    public float maxHealth = 100;
    public float currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        //HealthBar

        healthBar.SetActive(true);

        currentHealth -= damage;

        //Play Hurt Animation

        EnemyAnimator.SetTrigger("Hurt");

        CheckDeath();

        healthBarSlider.value = HealthPercentage();
    }

    public void CheckDeath()
    {
        if (currentHealth <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("Enemy Died!");

        //Die Animation

        EnemyAnimator.SetBool("IsDead", true);

        //Destroy Enemy
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Component.Destroy(healthBar);
        DestroyEnemy();

    }

    public void DestroyEnemy()
    {
        Destroy(gameObject, 2);
    }

    private float HealthPercentage()
    {
        return (currentHealth / maxHealth);
    }
}
