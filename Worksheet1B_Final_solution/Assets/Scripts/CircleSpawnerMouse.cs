using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawnerMouse : MonoBehaviour
{
    Vector3 mousePos;
    public GameObject myCirclePrefab;

    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);

        if (Input.GetButtonDown("Fire1") && (count<5))
        {
            Instantiate(myCirclePrefab, mousePos, Quaternion.identity);
            count++;
        }
        
        Debug.Log(mousePos);


    }
}
