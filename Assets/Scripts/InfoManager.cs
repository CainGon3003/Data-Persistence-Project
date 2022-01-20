using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class InfoManager : MonoBehaviour
{
    public static InfoManager Instance;

    public string Name;
    public int HighScore;
    public string TempName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]
    class SaveData
    {
        public int HighScore;
        public string Name;
    }
    
    
    public void SaveInfo()
    {
        SaveData data = new SaveData();
        data.HighScore = HighScore;
        data.Name = Name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadInfo()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);

            SaveData data = JsonUtility.FromJson<SaveData>(json);

            Name = data.Name;
            HighScore = data.HighScore;
        }
    }
    
}
