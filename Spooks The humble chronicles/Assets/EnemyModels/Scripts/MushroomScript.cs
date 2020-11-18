using UnityEngine;

public class MushroomScript : MonoBehaviour, ITakeDamage
{
    [SerializeField] private float _health = 20;
    [SerializeField] private Animator _animator;
    public void TakeSwordDamage(float damage)
    {
        _health -= damage;
        if (_health <= 0)
        {
            _animator.SetTrigger("Death");
            Destroy(gameObject.GetComponent<SphereCollider>());
            Destroy(gameObject.GetComponent<Rigidbody>());
        }
        else
        {
            _animator.SetTrigger("Hit");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        ITakeEnemyDamage hit = collision.collider.gameObject.GetComponent<ITakeEnemyDamage>();
        hit?.TakeEnemyDamage(5);
    }


}
