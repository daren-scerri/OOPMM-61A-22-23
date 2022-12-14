using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int startHealth, scorevalue;
    private int health;

    public Text healthText;
    // Start is called before the first frame update
    void Start()
    {
        health = startHealth;
        healthText.text = health.ToString();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        {
            other.gameObject.SetActive(false);
            health--;
            healthText.text = health.ToString();
            Debug.Log("Enemy health:" + health.ToString());

            if (health <= 0)
            {
                GameData.Score += scorevalue;
                GameManager.Instance.DisplayScore();
                Debug.Log("Game Score: " + GameData.Score.ToString());
                Destroy(this.gameObject);
            }

        }


        if (other.gameObject.name.Contains("Wall"))
        {
            GameData.PlayerHealth--;
            Debug.Log("player health: " + GameData.PlayerHealth.ToString());
            if (GameData.PlayerHealth <=0 ) GameManager.Instance.LoseGame();
        }
    }
}
