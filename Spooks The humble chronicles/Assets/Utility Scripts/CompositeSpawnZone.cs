using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeSpawnZone : SpawnZone
{
    [SerializeField] private bool _surfaceOnly;
    [SerializeField] private SpawnZone[] _spawnZones;
    public override Vector3 SpawnPoint
    {
        get
        {
            int index = Random.Range(0, _spawnZones.Length);
            return _spawnZones[index].SpawnPoint;
        }
    }


}
