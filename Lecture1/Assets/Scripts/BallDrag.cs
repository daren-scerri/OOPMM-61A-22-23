using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDrag : MonoBehaviour
{
    Vector3 mousePos;
    private void OnMouseDrag()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - new Vector3(0f, 0f, Camera.main.transform.position.z);
        this.gameObject.transform.position = mousePos;
    }
}
