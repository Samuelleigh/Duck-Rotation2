using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Class_Wave {

    public string waveName;
    public int wavelevel;
    public List<string> conditionsNeeded;
    public enum Endtype { TimeLimit, KillLimit };
    public List<Class_Enemy> Enemies;

}
