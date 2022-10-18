using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public GameObject myprefab;
    GameObject myplayer;
    float xmin, xmax, ymin, ymax, newxpos, newypos;
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

        myplayer = Instantiate(myprefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            newxpos = Mathf.Clamp(myplayer.transform.position.x - 1, xmin, xmax);
            myplayer.transform.position = new Vector3(newxpos, myplayer.transform.position.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            newxpos = Mathf.Clamp(myplayer.transform.position.x + 1, xmin, xmax);
            myplayer.transform.position = new Vector3(newxpos, myplayer.transform.position.y, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            newypos = Mathf.Clamp(myplayer.transform.position.y - 1, ymin, ymax);
            myplayer.transform.position = new Vector3(myplayer.transform.position.x, newypos, 0f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            newypos = Mathf.Clamp(myplayer.transform.position.y + 1, ymin, ymax);
            myplayer.transform.position = new Vector3(myplayer.transform.position.x, newypos, 0f);
        }

    }
}
