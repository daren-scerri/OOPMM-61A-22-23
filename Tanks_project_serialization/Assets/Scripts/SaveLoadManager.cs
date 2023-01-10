using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

using System.Runtime.Serialization.Formatters.Binary;
public class SaveLoadManager 
{

    public void SaveData()
    {
        SerializedData mySerializedData = new SerializedData();
        mySerializedData.ser_score = GameData.GameScore;
        mySerializedData.ser_lives = GameData.Lives;

        BinaryFormatter bf = new BinaryFormatter();

        FileStream myfile = File.Create(Application.persistentDataPath + "/TanksData.save");
        bf.Serialize(myfile, mySerializedData);  //Serialize and save
        myfile.Close();
        Debug.Log("FILE SAVED");


        //USING JSON
        /*
        string jsonToSave = JsonUtility.ToJson(mySerializedData);  //SERIALIZE TO JSON
        Debug.Log(jsonToSave);
        System.IO.File.WriteAllText(Application.persistentDataPath + "/TanksData.json", jsonToSave); //SAVE TO JSON FILE
        */
    }

    public void LoadData()
    {
        SerializedData mySerializedData = new SerializedData();

        if (File.Exists(Application.persistentDataPath + "/TanksData.save"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream myfile = File.Open(Application.persistentDataPath + "/TanksData.save", FileMode.Open);
            mySerializedData = (SerializedData)bf.Deserialize(myfile);
            myfile.Close();

            GameData.GameScore = mySerializedData.ser_score;
            GameData.Lives = mySerializedData.ser_lives;
        }

            //USING JSON
            /*
            if (File.Exists(Application.persistentDataPath + "/TanksData.json"))
            {
                string jsonLoaded = File.ReadAllText(Application.persistentDataPath + "/TanksData.json");
                mySerializedData = JsonUtility.FromJson<SerializedData>(jsonLoaded);
                GameData.GameScore = mySerializedData.ser_score;
                GameData.Lives = mySerializedData.ser_lives;

            }
            */
        }

    public void DeleteFile()
    {
        if (File.Exists(Application.persistentDataPath + "/TanksData.save"))
        {
            File.Delete(Application.persistentDataPath + "/TanksData.save");
        }

        /*
        if (File.Exists(Application.persistentDataPath + "/TanksData.json"))
        {
            File.Delete(Application.persistentDataPath + "/TanksData.json");
        }
        */

        if (File.Exists(Application.persistentDataPath + "/TanksData.save"))
        {
            File.Delete(Application.persistentDataPath + "/TanksData.save");
        }

    }

}
