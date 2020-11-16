using UnityEngine;

public class ShieldScript : MonoBehaviour, IToggleShield
{
    private CapsuleCollider _Collider;

    public void ToggleShieldCollider(bool toggle)
    {
        _Collider.enabled = toggle;
    }

    // Start is called before the first frame update
    void Start()
    {
        _Collider = GetComponent<CapsuleCollider>();
        _Collider.enabled = false;
    }

    
}
