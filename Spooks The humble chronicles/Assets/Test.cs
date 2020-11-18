using UnityEngine;

public class Test : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ITakeEnemyDamage hit = collision.collider.gameObject.GetComponent<ITakeEnemyDamage>();
        hit?.TakeEnemyDamage(5);
    }
}
