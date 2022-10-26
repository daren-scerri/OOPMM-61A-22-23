using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVertical : MonoBehaviour
{
    public float yspeed;
    // Start is called before the first frame update
    void Start()
    {
      //  yspeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, yspeed * Time.deltaTime, 0f);
    }
}
