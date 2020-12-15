using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public Player player;
    public HealthBar healthBar;
    private Rigidbody2D rb;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "damageObject")
        {
            player.TakeDamage(player.damage);
            healthBar.SetHealth(player.currentHealth);
            // Debug.Log("Hit Detected!");
        }
        
        
    }
}
