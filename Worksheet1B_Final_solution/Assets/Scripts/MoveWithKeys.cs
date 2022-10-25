using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithKeys : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject myPrefab, myShape;
    float XMin, XMax, YMin, YMax, newxpos;
    public float padding;

    void Start()
    {
        XMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + padding;
        Debug.Log(XMin);
        XMax = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - padding;
        Debug.Log(XMax);
        YMin = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + padding;
        Debug.Log(YMin);
        YMax = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - padding;
        Debug.Log(YMax);


        myPrefab = Resources.Load("Prefabs/Square") as GameObject;
        myShape = Instantiate(myPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("key pressed");
            newxpos = Mathf.Clamp(myShape.transform.position.x + 1, XMin, XMax);  //do not let square leave screen
            myShape.transform.position = new Vector3(newxpos, myShape.transform.position.y, 0);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("key pressed");
            newxpos = Mathf.Clamp(myShape.transform.position.x - 1, XMin, XMax);
            myShape.transform.position = new Vector3(newxpos, myShape.transform.position.y, 0);
        }



    }
}
