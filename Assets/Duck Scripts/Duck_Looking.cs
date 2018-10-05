using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duck_Looking : MonoBehaviour {

    public Camera cam;
    
    float currentAngle = 50.0f; 
    float speed;
    Vector3 lookHere;

    // Use this for initialization
    void Start () {


	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit))
        {

            Transform objectHit = hit.transform;
            lookHere.Set(hit.point.x, transform.position.y, hit.point.z);
           // Debug.Log(lookHere);

            transform.LookAt(lookHere);

        }

    }
}
