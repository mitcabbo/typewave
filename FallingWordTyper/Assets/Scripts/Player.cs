using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int maxHealth = 5;
    public int currentHealth;
    public int damage = 1;
    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        // Set player health to max
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Insert Update here that checks for when currentHealth <= 0
    void Update()
    {
        if(currentHealth <= 0)
        {
            // Kill program and Game Over screen
            // Debug.Log("Dead!");
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    // When the "word" game object collides with the platform edge collider, execute TakeDamage
    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        healthBar.SetHealth(currentHealth);
    }
}
