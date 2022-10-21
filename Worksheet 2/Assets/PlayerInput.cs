using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public GameObject prefab1, prefab2;
    GameObject bob, alice; // declare bob and alice
    int playerHP = 10; //This is our hp
    void Awake()
    {
        bob = Instantiate(prefab1, new Vector3(-3f, 0f, 0f), Quaternion.identity);
        alice = Instantiate(prefab2, new Vector3(3f, 0f, 0f), Quaternion.identity);
        
        bob.GetComponent<Enemy>().hitpoints = 5;
        bob.GetComponent<Enemy>().damage = 2;
        bob.GetComponent<Enemy>().enemyname = "Bob";

        alice.GetComponent<Enemy>().hitpoints = 2;
        alice.GetComponent<Enemy>().damage = 5;
        alice.GetComponent<Enemy>().enemyname = "Alice";

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            bob.GetComponent<Enemy>().TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            alice.GetComponent<Enemy>().TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= bob.GetComponent<Enemy>().damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= alice.GetComponent<Enemy>().damage;
            Debug.Log("Player HP: " + playerHP);
        }

        if (bob.GetComponent<Enemy>().hitpoints < 1)
            //if bob's hp is under 1, he dies
            bob.GetComponent<Enemy>().Die();
        if (alice.GetComponent<Enemy>().hitpoints < 1)
            //if alice's hp is under 1, she dies
            alice.GetComponent<Enemy>().Die();
        if (playerHP < 1)
            //if our hp is under 1, we die
            Debug.Log("You Died!");
    }
}