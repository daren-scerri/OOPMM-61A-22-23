using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hitpoints, damage;
    public string enemyname;
    
    void Awake()
    {

    }
    public void TakeDamage()
    {
        hitpoints--; //reduce HP by 1
        GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color - new Color(0.1f, 0f, 0f, 0f);
        Debug.Log(enemyname + "'s HP: " + hitpoints); //print out new hp
    }
    public void Die()
    {
        Debug.Log(enemyname + " Has Died");  //print to the console
        Destroy(this.gameObject);  
    }
}
