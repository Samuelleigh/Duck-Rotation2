using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Basic : MonoBehaviour {

    /// <summary>
    /// Enemy types:
    /// 
    /// 1. Go towards the player
    /// 
    /// 2. spirals around the player
    /// 
    /// 3. Follows a specific path towards player
    /// 
    /// 4. 
    /// 
    ///
    /// </summary>
    /// 

    public int movementType;
    public int speed = 2;

    public GameObject target;
    public Vector3 lookHere;
    

    private void Awake()
    {
        target = GameObject.Find("Duck");
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (movementType == 0) {

            lookHere.Set(target.transform.position.x, target.transform.position.y, target.transform.position.z);
            transform.LookAt(lookHere);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }
	}

    private void OnCollisionEnter(Collision col)
    {
        Debug.Log("hit");

        Destroy(col.gameObject);
            Destroy(gameObject);
        
    }

}
