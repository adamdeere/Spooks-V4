﻿using UnityEngine;

public class CastSpellScript : MonoBehaviour
{
    [SerializeField] private Transform _HandPositionTransform;
    [SerializeField] private Transform _ShootPosition;
    [SerializeField] private GameObject _HandEffectPrefab;
    [SerializeField] private GameObject _FireballPrefab;
    public void StartFireballSpell()
    {
        GameObject hEffect = Instantiate(_HandEffectPrefab, _HandPositionTransform);
        Destroy(hEffect, 10);
    }

    public void StartHeavySpell()
    {
       
    }

    public void ShootSpell()
    {
        Instantiate(_FireballPrefab, _ShootPosition.position, _ShootPosition.rotation);
    }
    public void ActivateAddtionalEffect()
    {
        Debug.Log("Started heavy spell");
    }
    public void ActivateEffect()
    {
        Debug.Log("Started heavy spell");
    }
}
