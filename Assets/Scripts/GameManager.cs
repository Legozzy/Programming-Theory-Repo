using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Character player;
    [SerializeField] private Character enemy;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.Attack(enemy);
        } 
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            enemy.Attack(player);
        }
    }
}
