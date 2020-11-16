using UnityEngine;

public class DamageScript : MonoBehaviour, ITakeEnemyDamage
{
    [SerializeField] private string lols;
    public void TakeEnemyDamage(float damage)
    {
        Debug.Log($"{lols} for {damage} damage");
    }

    
}
