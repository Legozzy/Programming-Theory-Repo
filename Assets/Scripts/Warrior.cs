using UnityEngine;

public class Warrior : Character
{
    public override void Attack(IDamageable target)
    {
        if (target is null)
            return;

        Debug.Log("Warrior attacks");
        target.TakeDamage(25f);
    }

    protected override void Die()
    {
        Debug.Log("Warrior died");
        Destroy(gameObject);
    }
}
