﻿using UnityEngine;

public class PlantScript : MonoBehaviour, ITakeSwordDamage, IMagicDamage
{
    [SerializeField] private Animator _PlantAnimator;
    
    public void TakeMagicDamage(float damage)
    {
        throw new System.NotImplementedException();
    }

    public void TakeSwordDamage(float damage)
    {
        _PlantAnimator.SetTrigger("death");
        Destroy(gameObject.GetComponent<CapsuleCollider>());
        Destroy(gameObject.GetComponent<Rigidbody>());
    }
}
