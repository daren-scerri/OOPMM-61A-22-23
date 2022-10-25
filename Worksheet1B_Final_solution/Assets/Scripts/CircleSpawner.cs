using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour
{
    public GameObject mycirclePrefab;
    public float padding;
    private float XMin, XMax, YMin, YMax;

    // Start is called before the first frame update
    void Start()
    {
        Camera gameCamera = Camera.main;
        XMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        Debug.Log("XMin: " + XMin.ToString());
        XMax = gameCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        Debug.Log("XMax: " + XMax.ToString());
        YMin = gameCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        Debug.Log("YMin: " + XMin.ToString());
        YMax = gameCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
        Debug.Log("YMax: " + XMin.ToString());




        Instantiate(mycirclePrefab, new Vector3(XMin, YMin, 0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(XMin, YMax, 0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(XMax, YMin, 0), Quaternion.identity);
        Instantiate(mycirclePrefab, new Vector3(XMax, YMax, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
