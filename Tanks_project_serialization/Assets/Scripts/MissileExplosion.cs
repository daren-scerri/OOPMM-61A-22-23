using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileExplosion : MonoBehaviour {

    public GameObject explosionPrefab;

    public float explosionRadius = 2;

    public float explosionForce = 50;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name);

        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Collider2D[] collidersHit = Physics2D.OverlapCircleAll(transform.position, explosionRadius);

        Debug.Log(collision.gameObject.name);

        foreach (Collider2D collider in collidersHit)
        {
            Rigidbody2D targetBody = collider.GetComponent<Rigidbody2D>();
           // Debug.Log(targetBody.name);
            if (targetBody == null)
            {
                continue;
            }

            targetBody.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            Health targetHealth = collider.GetComponent<Health>();

            if (targetHealth == null)
            {
                continue;
            }

            targetHealth.TakeDamage();

        }  

        Destroy(gameObject);

    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
