using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// MoveHorizontal requires the GameObject to have a MoveVertical class(script) component
[RequireComponent(typeof(MoveVertical))]



public class MoveHorizontal : MonoBehaviour
{
    public float xspeed, yspeedchange = 0f;
    MoveVertical myverticalmovement;

    

    // Start is called before the first frame update
    void Start()
    {
        //   xspeed = 1;
        myverticalmovement = GetComponent<MoveVertical>();
    }

    // Update is called once per frame
    void Update()
    {
        myverticalmovement.yspeed = myverticalmovement.yspeed - yspeedchange;
        transform.Translate(xspeed * Time.deltaTime, 0f , 0f);
    }
}
