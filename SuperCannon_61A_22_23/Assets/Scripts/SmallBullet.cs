using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullet
{
    // Start is called before the first frame update
    protected override void Start()
    {
        speed = 10f;
        base.Start();
    }


}
