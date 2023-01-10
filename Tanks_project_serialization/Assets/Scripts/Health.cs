using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    // public int playerNumber = 1;

    [SerializeField] int startHealth = 10;

    private int currentHealth;

    private GameManager gameManager;

    // Use this for initialization
    void Start()
    {
        Debug.Log(currentHealth);
        currentHealth = startHealth;
        gameManager = FindObjectOfType<GameManager>();
    
    }

    public void TakeDamage()
    {
        currentHealth--;
        Debug.Log(currentHealth);
        
        if (currentHealth <= 0)
        {
            if (gameObject.tag == "Enemy" && gameManager != null) gameManager.OnEnemyDie();
            if (gameObject.tag == "Player" && gameManager != null) gameManager.OnPlayerDie();
            if (gameObject.tag == "FixedEnemy" && gameManager != null) gameManager.OnFixedEnemyDie();
            Die();
        }
    }

    void Die()
    {

        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}