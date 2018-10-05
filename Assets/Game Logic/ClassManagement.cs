using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class ClassManagement : MonoBehaviour {

    public Class_Wave[] allWaveData;
    public int levelID;
    public Class_Wave[] backup;

    // Use this for initialization
    void Start () {
        backup = DeepClone<Class_Wave[]>(allWaveData);

        DontDestroyOnLoad(gameObject);

        SceneManager.LoadScene("Game");
    }


    public Class_Wave[] GetCurrentWaveData()
    {
        levelID = 1;
        return allWaveData;
    }

    public void ResetRoundData()
    {

        allWaveData = DeepClone<Class_Wave[]>(backup);
    }








    public static T DeepClone<T>(T obj)
    {
        using (var ms = new MemoryStream())
        {
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, obj);
            ms.Position = 0;

            return (T)formatter.Deserialize(ms);
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
