using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereitObjects : MonoBehaviour {
    public Vector3[] path;
    public GameObject ob;
    public Transform startPos;
    Vector3 poz;

    public float offset = 0.1f;
    // Use this for initialization


    void Start () {

        poz = startPos.position;

        //  InvokeRepeating("Go", 2, 2);
       // Go();
    }
	
	// Update is called once per frame
	void Update () {
     
	}

    
}
