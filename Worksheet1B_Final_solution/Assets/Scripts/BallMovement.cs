using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 ballvelocity = new Vector2(Random.Range(50, 500), Random.Range(50, 500));

        this.GetComponent<Rigidbody2D>().velocity = ballvelocity * Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {

    }


}
