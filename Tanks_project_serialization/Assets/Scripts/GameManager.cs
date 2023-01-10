using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [SerializeField] Text playerScoreText;

    [SerializeField] Text livesText;

    [SerializeField] GameObject playerPrefab;

    SaveLoadManager mySaveLoadManager;

    // Use this for initialization
    void Start () {
        mySaveLoadManager = new SaveLoadManager();
        GameData.GameScore = 0;
        GameData.Lives = 3;
        mySaveLoadManager.LoadData();
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
        livesText.text = "Lives: " + GameData.Lives.ToString();
	}

    public void OnEnemyDie()
    {
      
        GameData.GameScore++;
        playerScoreText.text = "Score: " + GameData.GameScore.ToString();
        mySaveLoadManager.SaveData();
    }

    public void OnFixedEnemyDie()
    {
        mySaveLoadManager.DeleteFile();
        SceneManager.LoadScene("Win");

    }

    public void OnPlayerDie()
    {
        GameData.Lives--;
        mySaveLoadManager.SaveData();
        livesText.text = "Lives: " + GameData.Lives.ToString();
        if (GameData.Lives > 0) Instantiate(playerPrefab, new Vector3(-5f, 0f, 0f), Quaternion.identity);
        else
        {
            mySaveLoadManager.DeleteFile();
            SceneManager.LoadScene("GameOver");
        }
            
    }
    // Update is called once per frame
    void Update () {
		
	}
}
