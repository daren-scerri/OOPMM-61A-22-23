using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public class Bullet : MonoBehaviour
{
    public float speed=5;
    Vector3 mousePoint3D;
    // Start is called before the first frame update
    void Start()
    {
        mousePoint3D = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.back * Camera.main.transform.position.z);
        Vector2 direction = new Vector2(mousePoint3D.x, mousePoint3D.y + 5f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    
    }
}
