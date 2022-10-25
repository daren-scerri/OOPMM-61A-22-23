using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultBullet : MonoBehaviour
{
    protected int speed;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        speed = 1;
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
    }
}
