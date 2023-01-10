using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGun : MonoBehaviour {


    public GameObject missilePrefab;

    public Transform fireTransform;

    public float fireForce = 500;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
        {
            GameObject missile = Instantiate(missilePrefab, fireTransform.position, transform.rotation);

            Rigidbody2D missileBody = missile.GetComponent<Rigidbody2D>();

            missileBody.AddForce(transform.up * fireForce);
            
        }
	}
}
