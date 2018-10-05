using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons_Bullet : MonoBehaviour {

    public int speed = 10;
    public int timeTilDeath;

    // Use this for initialization
    void Start() {

    } 
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
	}

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
