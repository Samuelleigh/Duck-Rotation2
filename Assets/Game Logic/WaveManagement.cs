using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManagement : MonoBehaviour {

    //live varibles
    public int currentWave;
    public int currentLevelnum;
    public List<string> currentAttributes;



    //Class management
    public ClassManagement classManagement;
    public Class_Wave[] LevelData;

    //Enemy types
    public GameObject basic;

    public Quaternion temp;


    ///level Tracking
    public Class_Level currentLevel;

    //Wave Tracking
    public int currentPlaceInWave;
    public int timeTillNextSpawn;
    public 

    // Use this for initialization

    void Awake ()
    {
        classManagement = FindObjectOfType<ClassManagement>();
        LevelData = classManagement.GetCurrentWaveData();
    }


    void Start () {

        currentLevel.Waves = CreateLevelList(currentLevelnum);
           
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public List<Class_Wave> CreateLevelList(int currentLevelnum) {

        Class_Level newLevel = null;
        newLevel.levelNum = 4;

        return newLevel;
    }

    IEnumerator CycleThroughLevel(Class_Level WaveList) {

        for (int i = 0; i <= WaveList.Waves.Count; i++)
        {

            StartCoroutine(CycleThroughWave(WaveList.Waves[i]));

            yield return new WaitForSeconds(2);
        }

        currentLevelnum++;
        yield return new WaitForSeconds(3);

    }



    IEnumerator CycleThroughWave(Class_Wave EList) {

        for (int i = 0; i <= EList.Enemies.Count; i++ ){

            SpawnEnemy(EList.Enemies[i]);
            yield return new WaitForSeconds(EList.Enemies[i].timeSpawn);

        }

        yield return null;
    }


    public void SpawnEnemy(Class_Enemy Enemy) { 

        //if basic
        if (Enemy.type == 0) {

            Instantiate(basic,Enemy.spawnLocation,temp);

        }

   

    }
}
