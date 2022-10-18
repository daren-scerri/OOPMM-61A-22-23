using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetupGame : MonoBehaviour
{

    float xmin, ymin, xmax, ymax;
    public GameObject verticalwall, horizwall;
    public float padding = 0.5f;

    // Start is called before the first frame update
    void Start()
    {

        Camera mycamera = Camera.main;
        xmin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        ymin = mycamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        xmax = mycamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
        ymax = mycamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        Debug.Log("XMin: " + xmin.ToString());
        Debug.Log("YMin: " + ymin.ToString());
        Debug.Log("XMax: " + xmax.ToString());
        Debug.Log("YMax: " + ymax.ToString());

        float xmid = xmin + (xmax - xmin) / 2;
        float ymid = ymin + (ymax - ymin) / 2;

        Instantiate(horizwall, new Vector3(xmid, ymin, 0), Quaternion.identity);
        Instantiate(horizwall, new Vector3(xmid, ymax, 0), Quaternion.identity);
        Instantiate(verticalwall, new Vector3(xmin, ymid, 0), verticalwall.transform.rotation);
        Instantiate(verticalwall, new Vector3(xmax, ymid, 0), verticalwall.transform.rotation);

    }



}
