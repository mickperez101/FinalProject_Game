using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //Player Animation - Death
    private Animator PlayerAnimator;
    private bool dead;

    //Health
    [SerializeField] private float playerHealth;
    public float maxHealth = 100;

    //Health Bar
    public GameObject healthBar;
    public Slider healthBarSlider;


    private void Awake()
    {
        playerHealth = maxHealth;
        PlayerAnimator = GetComponent<Animator>();
    }
    // Start is called before the first frame update
    
    public void TakeDamage(float damage)
    {
        healthBar.SetActive(true);

        playerHealth = Mathf.Clamp(playerHealth - damage, 0, maxHealth);

        //playerHealth -= damage;

        if (playerHealth > 0)
        {
            //player hurt
            healthBarSlider.value = HealthPercentage();
            PlayerAnimator.SetTrigger("PlayerHurt");
        }

        else
        {
            if(!dead)
            {
                //player dead
                PlayerDie();

                Component.Destroy(healthBar);
                GetComponent<PlayerControls>().enabled = false;
                GetComponent<PlayerCombat>().enabled = false;
                GetComponent<Player>().enabled = false;
   
                dead = true;
            }
        }

    }

    void PlayerDie()
    {
        PlayerAnimator.SetTrigger("PlayerDeath");

        GetComponent<Collider2D>().enabled = false;
    }

    private float HealthPercentage()
    {
        return (playerHealth / maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
