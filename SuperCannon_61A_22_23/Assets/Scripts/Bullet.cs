using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]


public abstract class Bullet : MonoBehaviour   //the code down here applies to all types of bullets
{
    [SerializeField] protected float speed=0;
    Vector3 mousePoint3D;
    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    protected virtual void OnEnable()
    {
        mousePoint3D = GameData.MousePos;
        Vector2 direction = new Vector2(mousePoint3D.x, mousePoint3D.y + 5f);
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    void OnBecameInvisible()
    {
        // Destroy(this.gameObject);
        this.gameObject.SetActive(false);
    }


}
