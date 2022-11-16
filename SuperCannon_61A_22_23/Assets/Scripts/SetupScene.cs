using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupScene : MonoBehaviour
{

    GameObject vertWallprefab, horizWallprefab;

    void Start()
    {
        vertWallprefab = Resources.Load("prefabs/VerticalWall") as GameObject;
        horizWallprefab = Resources.Load("prefabs/HorizWall") as GameObject;

        Instantiate(vertWallprefab, new Vector3(GameData.XMin - 4, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(vertWallprefab, new Vector3(GameData.XMax + 4, 0, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallprefab, new Vector3(0, GameData.YMin - 4, 0), Quaternion.identity, this.gameObject.transform);
        Instantiate(horizWallprefab, new Vector3(0, GameData.YMax + 4, 0), Quaternion.identity, this.gameObject.transform);
    }


}
