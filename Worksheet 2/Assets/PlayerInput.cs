using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    Enemy bob, alice; // declare bob and alice
    int playerHP = 10; //This is our hp
    void Start()
    {
        bob = new Enemy(5, 2, "Bob");
        //Bob has 5 hp, 2 damage, and a name of Bob
        alice = new Enemy(2, 5, "Alice");
        //Alice has 2 hp, 5 damage, and a name of Alice
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            //Bob takes damage if Spacebar is pressed
            bob.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftShift))
            //Alice takes damage if left shift is pressed
            alice.TakeDamage();
        else if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            //Player takes damage from bob if left control is pressed
            playerHP -= bob.damage;
            Debug.Log("Player HP: " + playerHP);
        }
        else if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            //Player takes damage from alice if left alt is pressed
            playerHP -= alice.damage;
            Debug.Log("Player HP: " + playerHP);
        }

        if (bob.hitpoints < 1)
            //if bob's hp is under 1, he dies
            bob.Die();
        if (alice.hitpoints < 1)
            //if alice's hp is under 1, she dies
            alice.Die();
        if (playerHP < 1)
            //if our hp is under 1, we die
            Debug.Log("You Died!");
    }
}