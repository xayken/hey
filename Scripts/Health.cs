using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0.0f)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle death here (play death animation destroy object etc)
        Destroy(gameObject);
    }
}