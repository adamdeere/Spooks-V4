using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class ShapeFactory : ScriptableObject
{
    [SerializeField] private Shape[] prefabs;
    [SerializeField] private Material[] materials;
    

    private List<Shape>[] _pools;
    private Scene _poolScene;
    private void CreatePools()
    {
#if UNITY_EDITOR
       
        _poolScene = SceneManager.GetSceneByName(name);
        if (_poolScene.isLoaded)
        {
            GameObject[] rootObjects = _poolScene.GetRootGameObjects();
            for (int i = 0; i < rootObjects.Length; i++)
            {
                Shape pooledShape = rootObjects[i].GetComponent<Shape>();
                if (!pooledShape.gameObject.activeSelf)
                {
                    _pools[pooledShape.ShapeID].Add(pooledShape);
                }
            }
            return;
        }
           
#endif
        _poolScene = SceneManager.CreateScene(name);
        _pools = new List<Shape>[prefabs.Length];
        for (int i = 0; i < _pools.Length; i++)
        {
            _pools[i] = new List<Shape>();
        }
    }
    public Shape Get(int shapeId = 0, int mattId = 0)
    {
        Shape instance;
        if (_pools == null)
            CreatePools();

        List<Shape> pool = _pools[shapeId];
        int lastIndex = pool.Count - 1;

        if (lastIndex >= 0)
        {
            instance = pool[lastIndex];
            instance.gameObject.SetActive(true);
            pool.RemoveAt(lastIndex);
        }
        else
        {
            instance = Instantiate(prefabs[shapeId]);
            instance.ShapeID = shapeId;
            SceneManager.MoveGameObjectToScene(instance.gameObject, _poolScene);
        }
       
        instance.SetMaterial(materials[mattId],mattId);
        return instance;
    }

    public void Reclaim(Shape shapeToRecycle)
    {
        if (_pools == null)
            CreatePools();

        _pools[shapeToRecycle.ShapeID].Add(shapeToRecycle);
        shapeToRecycle.gameObject.SetActive(false);
        
    }

    public Shape GetRandom()
    {
        return Get(Random.Range(0, prefabs.Length), Random.Range(0, materials.Length));
    }
}
