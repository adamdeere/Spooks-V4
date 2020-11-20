using UnityEngine;

public class PlantScript : MonoBehaviour, ITakeDamage
{
    [SerializeField] private Animator _PlantAnimator; 

    public void TakeSwordDamage(float damage)
    {
        _PlantAnimator.SetTrigger("death");
        Destroy(gameObject.GetComponent<CapsuleCollider>());
        Destroy(gameObject.GetComponent<Rigidbody>());
    }
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.collider.gameObject.GetComponent<ITakeEnemyDamage>();
        hit?.TakeEnemyDamage(10);
    }
}
