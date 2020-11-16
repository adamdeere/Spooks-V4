using UnityEngine;

public class MushroomScript : MonoBehaviour, ITakeSwordDamage
{
    [SerializeField] private float _health = 20;
    [SerializeField] private Animator _animator;
    public void TakeSwordDamage(float damage)
    {
       // _animator.SetTrigger("dead");
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

    
}
