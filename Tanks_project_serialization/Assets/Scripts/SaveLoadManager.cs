using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveLoadManager 
{

    public void SaveData()
    {
        SerializedData mySerializedData = new SerializedData();
        mySerializedData.ser_score = GameData.GameScore;
        mySerializedData.ser_lives = GameData.Lives;

        string jsonToSave = JsonUtility.ToJson(mySerializedData);  //SERIALIZE TO JSON
        Debug.Log(jsonToSave);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/TanksData.json", jsonToSave); //SAVE TO JSON FILE

    }

    public void LoadData()
    {
        SerializedData mySerializedData = new SerializedData();
        if (File.Exists(Application.persistentDataPath + "/TanksData.json"))
        {
            string jsonLoaded = File.ReadAllText(Application.persistentDataPath + "/TanksData.json");
            mySerializedData = JsonUtility.FromJson<SerializedData>(jsonLoaded);
            GameData.GameScore = mySerializedData.ser_score;
            GameData.Lives = mySerializedData.ser_lives;

        }
    }

    public void DeleteFile()
    {
        if (File.Exists(Application.persistentDataPath + "/TanksData.json"))
        {
            File.Delete(Application.persistentDataPath + "/TanksData.json");
        }
    }

}
