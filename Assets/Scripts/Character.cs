using UnityEngine;

// ABSTRACTION
public abstract class Character : MonoBehaviour, IDamageable
{
    [SerializeField] protected float maxHealth = 100f;
    protected float currentHealth; // ENCAPSULATION

    protected virtual void Start()
    {
        currentHealth = maxHealth;
    }

    public abstract void Attack(IDamageable target);

    public virtual void TakeDamage(float damage)
    {
        currentHealth -= damage;
        UIManager.Instance.ShowMessage($"{gameObject.name} took {damage} damage. HP left: {currentHealth}");
        //Debug.Log($"{gameObject.name} took {damage} damage. HP left: {currentHealth}");
        
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    protected abstract void Die();
}
