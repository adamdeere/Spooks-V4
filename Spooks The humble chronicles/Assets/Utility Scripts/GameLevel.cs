using UnityEngine;

public class GameLevel : MonoBehaviour
{
    [SerializeField] private SpawnZone _spawnZone;
    // Start is called before the first frame update
    void Start()
    {
        Game.GameInstance._spawnZoneOfLevel = _spawnZone;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
