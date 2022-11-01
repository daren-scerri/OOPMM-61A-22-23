using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_Cannon : MonoBehaviour
{
    Vector3 mousePoint3D;
    Quaternion newrotation;

    Quaternion clampRotationLow, clampRotationHigh;
    // Start is called before the first frame update
    void Start()
    {
        clampRotationLow = Quaternion.Euler(0, 0, -70);
        Debug.Log(clampRotationLow);
        clampRotationHigh = Quaternion.Euler(0, 0, 70);
        Debug.Log(clampRotationHigh);
    }

    // Update is called once per frame
    void Update()
    {
        PointAtMouse();
    }

    void PointAtMouse()
    {
        mousePoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        Debug.Log(mousePoint3D);
        newrotation = Quaternion.LookRotation(transform.position - mousePoint3D, Vector3.forward);
        newrotation.x = 0;
        newrotation.y = 0;
        newrotation.z = Mathf.Clamp(newrotation.z, clampRotationLow.z, clampRotationHigh.z);
        newrotation.w = Mathf.Clamp(newrotation.w, clampRotationLow.w, clampRotationHigh.w);
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, newrotation, Time.deltaTime * 3f);
        //this.transform.rotation = newrotation;
    }

}
