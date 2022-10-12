using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWithMouse : MonoBehaviour
{
    Vector3 mousePos;
    Camera mycamera;
    public GameObject myprefab;
    int count=0;

    // Start is called before the first frame update
    void Start()
    {
        mycamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mycamera.ScreenToWorldPoint(Input.mousePosition) - new Vector3 (0f, 0f, mycamera.transform.position.z);
        Debug.Log(mousePos);
        if (Input.GetButtonDown("Fire1") && (count<5))
        {
            count++;
            Instantiate(myprefab, mousePos, Quaternion.identity);
        }
    }
}
