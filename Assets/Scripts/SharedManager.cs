using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class SharedManager : MonoBehaviour
{
    public static SharedManager Instance;

    public string playerName;
    public string highscoreName;
    public int highscore;

    void Awake()
    {
        if(Instance != null) Destroy(this);
        else Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [Serializable]
    class SaveData
    {
        public string highscoreName;
        public int highscore;
    }

    public void SaveHighscore()
    {
        SaveData data = new SaveData();

        data.highscoreName = playerName;
        data.highscore = highscore;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadHighscore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path)) 
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            highscoreName = data.highscoreName;
            highscore = data.highscore;
        }
    }
}
