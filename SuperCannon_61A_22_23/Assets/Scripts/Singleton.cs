using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic Singleton class
public class Singleton<T> : MonoBehaviour where T : Component{
    
    private static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null && FindObjectOfType<T>() == null)
            {
                //With this, it is not mandatory for Singleton to manually be placed in the scene
                GameObject o = new GameObject();
                o.name = typeof(T).Name;
                _instance = o.AddComponent<T>();
            }
            return _instance;
        }
    }

    public virtual void Awake()
    {
        if (_instance == null) _instance = this as T;
        else Destroy(gameObject);
    }
}
