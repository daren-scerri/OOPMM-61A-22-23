using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameData : MonoBehaviour
{
    private static int _score = 0;
    private static int _playerhealth = 5;

    public static int Score
    {
        get { return _score; }
        set { _score = value; }
    }


    public static int PlayerHealth
    {
        get { return _playerhealth; }
        set { _playerhealth = value; }
    }


    public static float XMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x; }
    }

    public static float XMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x; }
    }

    public static float YMin
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y; }
    }

    public static float YMax
    {
        get { return Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y; }
    }


    public static Vector3 MousePos
        {
        get { return GetMousePos(); }
    }

    private static Vector3 GetMousePos()
    {
        Vector3 mousePoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
      //  Debug.Log(mousePoint3D);
        return mousePoint3D;
    }
 

}



