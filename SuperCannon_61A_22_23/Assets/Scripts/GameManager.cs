using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    public int currentLevel;
    public Text scoreText;
    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
        GameData.Score = 0;
        DisplayScore();
        SceneManager.sceneLoaded += OnSceneLoaded;
     
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + GameData.Score.ToString();
    }


    public void LoseGame()
    {
        SceneManager.LoadScene("LoseScene");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "LoseScene")
        {
            //  scoreText = GameObject.Find()
            DisplayScore();
            //DO WHAT YOU WANT IN LOSE SCENE
        }
    }

}
