using UnityEngine;

// INHERITANCE
public class Enemy : Character
{
    // POLYMORPHISM
    public override void Attack(IDamageable target)
    {
        UIManager.Instance.ShowMessage("Enemy attacks!");
        //Debug.Log("Enemy attacks");
        target.TakeDamage(15f);
    }

    // POLYMORPHISM
    protected override void Die()
    {
        UIManager.Instance.ShowMessage("Enemy died");
        //Debug.Log("Enemy died");
        Destroy(gameObject);
    }
}
