using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    }

    public void DisplayScore()
    {
        scoreText.text = "Score: " + GameData.Score.ToString();
    }



}
