using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
    public static GameObjectPool instance;
    public List<GameObject> platformPool;
    public List<GameObject> springPlatformPool;
    [Tooltip("Object that is gonna be cloned and returned in this pool")]
    public GameObject platform1ToPool;
    public GameObject platform2ToPool;
    [Tooltip("Starting size of the pool")]
    public uint poolSize;
    [Tooltip("Should the pool be expanded if it doesn't find any Inactive GameObject?")]
    public bool shouldExpand = true;

    void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        Init(poolSize);
    }

    public void Init(uint _size)
    {
        platformPool = new List<GameObject>();
        springPlatformPool = new List<GameObject>();

        for (int i = 0; i < _size; i++)
        {
            AddGameObjectToPool(platform1ToPool, platformPool);
            AddGameObjectToPool(platform2ToPool, springPlatformPool);
        }
    }

    public GameObject GetInactiveGameObject(List<GameObject> list)
    {
        foreach (GameObject o in list)
        {
            if (!o.activeInHierarchy)
            {
                return o;
            }
        }

        if (shouldExpand)
        {
            return AddGameObjectToPool(platform1ToPool, platformPool);
        }

        return null;
    }

    private GameObject AddGameObjectToPool(GameObject objToPool, List<GameObject> pool)
    {
        GameObject obj = Instantiate(objToPool, transform);
        obj.SetActive(false);
        pool.Add(obj);
        return obj;
    }
}