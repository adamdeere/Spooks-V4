using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    [SerializeField] private float damagePower = 1;
    private void Start()
    {
        gameObject.SetActive(false);
    }

    /// <summary>
    /// animation event to ensure the sword only does damage when swung
    /// </summary>
    /// <param name="enable"></param>
    public void ColliderEnable(bool enable)
    {
        gameObject.SetActive(enable);
    }

    /// <summary>
    /// will only deal damage to anything with an ISwordDamage interface
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.collider.gameObject.GetComponent<ISwordDamage>();
        hit?.DealSwordDamage(damagePower);
    }
}
