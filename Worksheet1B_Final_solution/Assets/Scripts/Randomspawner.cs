using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Randomspawner : MonoBehaviour
{
    public GameObject myCirclePrefab;
    public float padding;

    private float XMin, XMax, YMin, YMax;
    private float timer = 0;
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
        timer += Time.deltaTime * 1000;
        if ((int)(timer) % 100 == 0)
        {
            Debug.Log(timer);
            Vector2 newposition = new Vector2(Random.Range(XMin, XMax), Random.Range(YMin, YMax));
            Instantiate(myCirclePrefab, new Vector3(newposition.x, newposition.y, 0), Quaternion.identity);
        }
    }
}

