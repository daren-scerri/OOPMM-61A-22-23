using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnemy : FixedEnemy
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        transform.position = Vector3.MoveTowards(transform.position, playertank.transform.position, 1f * Time.deltaTime);
    }
}
