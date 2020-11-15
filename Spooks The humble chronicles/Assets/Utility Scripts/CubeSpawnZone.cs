using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnZone : SpawnZone
{
    [SerializeField] private bool _surfaceOnly;
    public override Vector3 SpawnPoint
    {
        get
        {
            Vector3 pos;
            pos.x = Random.Range(-0.5f, 0.5f);
            pos.y = Random.Range(-0.5f, 0.5f);
            pos.z = Random.Range(-0.5f, 0.5f);
            return transform.TransformPoint(pos);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireCube(Vector3.zero, Vector3.one);
    }
}
