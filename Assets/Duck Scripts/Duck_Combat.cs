using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Combat : MonoBehaviour {


    public int combatMode;

    public GameObject bullet;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0)) {

            Instantiate(bullet,transform.position,transform.rotation);



        }

	}
}
