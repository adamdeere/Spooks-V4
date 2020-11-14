using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Game : PersistableObject
{
    public static Game GameInstance { get; private set; }

    [SerializeField] private PersistantStorage _storage;
    [SerializeField] private ShapeFactory shapeFactory;
    [SerializeField] private int sceneIndex = 1;
    [SerializeField] public SpawnZone _spawnZoneOfLevel { get; set; }
    private int loadLevelBuildIndex;
   
    private List<Shape> shapes;

    private IEnumerator LoadLevel(int levelbuildIndex)
    {
        enabled = false;
        if (loadLevelBuildIndex > 0)
            yield return SceneManager.UnloadSceneAsync(loadLevelBuildIndex);
        
        yield return SceneManager.LoadSceneAsync(levelbuildIndex, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(levelbuildIndex));
        loadLevelBuildIndex = levelbuildIndex;
        enabled = true;
    }
    private void OnEnable()
    {
        GameInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
      
        shapes = new List<Shape>();
#if UNITY_EDITOR

        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene loadedScene = SceneManager.GetSceneAt(i);
            if (loadedScene.name.Contains("Level"))
            {
                SceneManager.SetActiveScene(loadedScene);
                loadLevelBuildIndex = loadedScene.buildIndex;
                return;
            }
        }
#endif
        StartCoroutine(LoadLevel(sceneIndex));
    }

   
    private void NextLevel()
    {
        RestartGame();
        sceneIndex++;
        if (sceneIndex > SceneManager.sceneCountInBuildSettings - 1)
            sceneIndex = 1;

        StartCoroutine(LoadLevel(sceneIndex));
    }

    private void DestroySprite()
    {
        if (shapes.Count > 0)
        {
            int index = Random.Range(0, shapes.Count);
            shapeFactory.Reclaim(shapes[index]);
            int lastIndex = shapes.Count - 1;
            shapes[index] = shapes[lastIndex];
            shapes.RemoveAt(lastIndex);
        }
    }

    private void SaveSprite()
    {
        _storage.Save(this);
    }
    public override void Save(GameDataWriter writer)
    {
        int count = shapes.Count;
        writer.Write(count);
        writer.Write(loadLevelBuildIndex);
        for (int i = 0; i < count; i++)
        {
            writer.Write(shapes[i].ShapeID);
            writer.Write(shapes[i].MaterialId);
            shapes[i].Save(writer);
        }
    }
    private void RestartGame()
    {
        for (int i = 0; i < shapes.Count; i++)
        {
            shapeFactory.Reclaim(shapes[i]);
        }
        shapes.Clear();
    }

    private void LoadSprites()
    {
        RestartGame();
        _storage.Load(this);
    }
    public override void Load(GameDataReader reader)
    {
        int count = reader.ReadInt();
        StartCoroutine(LoadLevel(reader.ReadInt()));
        for (int i = 0; i < count; i++)
        {
            int shapeId = reader.ReadInt();
            int mattId = reader.ReadInt();
            Shape instance = shapeFactory.Get(shapeId, mattId);
            instance.Load(reader);
            shapes.Add(instance);
        }
    }
    private void CreateSprite()
    {
        Shape instance = shapeFactory.GetRandom();
        Transform t = instance.transform;
        t.localPosition = _spawnZoneOfLevel.SpawnPoint;
        t.localRotation = Random.rotation;
        t.localScale = Vector3.one * UnityEngine.Random.Range(0.1f, 2f);
        instance.SetColour(UnityEngine.Random.ColorHSV(0f, 1f, 0.5f, 1f, 0.25f, 1f, 1f, 1f));
        shapes.Add(instance);
    }
}
