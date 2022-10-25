using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ballspawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    public float padding;

    private float XMin, XMax, YMin, YMax;
    
    // Start is called before the first frame update
    void Start()
    {
        Camera myCamera = Camera.main;
        XMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        Debug.Log("XMin: " + XMin.ToString());
        XMax = myCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        Debug.Log("XMax: " + XMax.ToString());
        YMin = myCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        Debug.Log("YMin: " + YMin.ToString());
        YMax = myCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
        Debug.Log("YMax: " + YMax.ToString());

        // myCirclePrefab = (GameObject)Resources.Load("Circle");
        Instantiate(myCirclePrefab, new Vector3(XMin, YMin, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMin, YMax, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax, YMin, 0), Quaternion.identity);
        Instantiate(myCirclePrefab, new Vector3(XMax, YMax, 0), Quaternion.identity);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
