using UnityEngine;

public class SwordAttack : MonoBehaviour, IDealSwordDamage
{
    [SerializeField] private float damagePower = 10f;
    private void Start()
    {
        gameObject.SetActive(false);
    }
    /// <summary>
    /// will only deal damage to anything with an ISwordDamage interface
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        var hit = collision.collider.gameObject.GetComponent<ITakeSwordDamage>();
        hit?.TakeSwordDamage(damagePower);
    }

    public void ToogleSwordCollider(bool switchOn)
    {
        gameObject.SetActive(switchOn);
    }
}
