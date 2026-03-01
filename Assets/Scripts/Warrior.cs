using UnityEngine;

public class Warrior : Character
{
    public override void Attack(Character target)
    {
        Debug.Log("Warrior attacks");
        target.TakeDamage(20f);
    }

    protected override void Die()
    {
        Debug.Log("Warrior died");
        Destroy(gameObject);
    }
}
