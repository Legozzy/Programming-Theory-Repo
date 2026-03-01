using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float maxHealth = 100f;
    protected float currentHealth;

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public abstract void Attack(Character target);

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        Debug.Log($"{gameObject.name} took {damage} damage. HP left: {currentHealth}");
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}
