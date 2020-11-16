using UnityEngine;

public class DamagePlayer : MonoBehaviour, ITakeEnemyDamage
{
    [SerializeField] private string lols;
    public void TakeEnemyDamage(float damage)
    {
        Debug.Log($"{lols} for {damage} damage");
    }

    
}
