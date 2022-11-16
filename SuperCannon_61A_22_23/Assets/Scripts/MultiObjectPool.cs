using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiObjectPool : MonoBehaviour
{
    

    [System.Serializable] public struct objectToPool
        {
        public GameObject gameobjectToPool;
        public int amountToPool;
        }

    public static MultiObjectPool SharedInstance;
    public List<GameObject> pooledObjects;
    public List<objectToPool> objectsToPool;
   
    void Awake()
    {
        SharedInstance = this;
    }
    void Start()
    {
        pooledObjects = new List<GameObject>();
        GameObject tmp;
      
        for (int o = 0; o < objectsToPool.Count; o++)
        {
            for (int i = 0; i < objectsToPool[o].amountToPool; i++)
            {
                tmp = Instantiate(objectsToPool[o].gameobjectToPool);
                tmp.transform.parent = this.gameObject.transform;
                tmp.SetActive(false);
                pooledObjects.Add(tmp);
            }


        }
      
    }

    public GameObject GetPooledObject(string objectName)
    {
        for (int i=0; i< pooledObjects.Count; i++ )
        {
            if(!pooledObjects[i].activeInHierarchy && pooledObjects[i].name.Contains(objectName))
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
