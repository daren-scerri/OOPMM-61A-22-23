using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Vector2 velocity = new Vector2(80f,120f);
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Rigidbody2D>().velocity = velocity * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime.ToString());  //Watch time between frames in console

    }
}
