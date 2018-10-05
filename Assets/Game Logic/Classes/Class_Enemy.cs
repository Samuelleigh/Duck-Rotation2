using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Class_Enemy {

    public enum EnemyType {Basic,Blocker};
    public EnemyType type;
    public int Level;
    public int timeSpawn;
    [NonSerialized]
    public Vector3 spawnLocation;

	
}
