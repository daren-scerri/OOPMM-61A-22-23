using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    public static Vector3 MousePos
        {
        get { return GetMousePos(); }
    }

    private static Vector3 GetMousePos()
    {
        Vector3 mousePoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        Debug.Log(mousePoint3D);
        return mousePoint3D;
    }
 

}
