using UnityEngine;

// INHERITANCE
public class Warrior : Character
{

    // POLYMORPHISM
    public override void Attack(IDamageable target)
    {
        if (target is null)
            return;

        UIManager.Instance.ShowMessage("Warrior attacks!");
        //Debug.Log("Warrior attacks");
        target.TakeDamage(25f);
    }

    // POLYMORPHISM
    protected override void Die()
    {
        UIManager.Instance.ShowMessage("Warrior died");
        //Debug.Log("Warrior died");
        Destroy(gameObject);
    }
}
