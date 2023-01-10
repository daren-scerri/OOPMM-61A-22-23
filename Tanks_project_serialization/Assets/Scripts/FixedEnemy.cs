using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedEnemy : MonoBehaviour
{

    // How quickly player moves forward and back
    public float speed = 10f;

    // How quickly player rotates (degrees per second)
    public float rotationSpeed = 180f;

    protected GameObject playertank;

    // Use this for initialization
    public virtual void Start()
    {
                
    }

    // Update is called once per frame
    public virtual void Update()
    {
        playertank = GameObject.FindGameObjectWithTag("Player");
        Quaternion newRotation = Quaternion.identity;
        if (playertank != null) newRotation = Quaternion.LookRotation(transform.position - playertank.transform.position, Vector3.forward);
        newRotation.x = 0f;
        newRotation.y = 0f;

        //transform.rotation = newRotation;  //**no slurp
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * 4);

        
    }

    // Returns input values of 0, 1 or -1 based on whether Player tries to move forward or back
    
}
