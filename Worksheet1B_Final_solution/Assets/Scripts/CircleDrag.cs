using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleDrag : MonoBehaviour
{
    private Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0f, 0f, 10f);
        this.gameObject.transform.position = mousePos;
    }

}
