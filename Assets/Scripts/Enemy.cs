using UnityEngine;

public class Enemy : Character
{
    public override void Attack(IDamageable target)
    {
        Debug.Log("Enemy attacks");
        target.TakeDamage(15f);
    }

    protected override void Die()
    {
        Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}
