using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBullet : Bullet
{
    // Start is called before the first frame update
    protected override void OnEnable()
    {
        speed = 10f;
        base.OnEnable();
    }


}
