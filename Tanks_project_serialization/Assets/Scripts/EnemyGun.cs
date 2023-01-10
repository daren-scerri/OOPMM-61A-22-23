using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGun : MonoBehaviour
{
    public GameObject missilePrefab;

    public Transform fireTransform;

    public float fireForce=500;

    Coroutine enemyfireCoroutine;
    // Start is called before the first frame update
    void Start()
    {
        enemyfireCoroutine = StartCoroutine(FiringCoRoutine());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FiringCoRoutine()
    {
        while (true)
        {
            float timer = Random.Range(1f, 5f);
            GameObject missile = Instantiate(missilePrefab, fireTransform.position, transform.rotation);

            Rigidbody2D missileBody = missile.GetComponent<Rigidbody2D>();

            missileBody.AddForce(transform.up * fireForce);
            yield return new WaitForSeconds(timer);
        }

    }



}
