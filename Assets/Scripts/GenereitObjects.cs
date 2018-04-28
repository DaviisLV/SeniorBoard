using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereitObjects : MonoBehaviour {

    public GameObject ob;
    public Transform startPos;
    Vector3 poz;
	// Use this for initialization
	void Start () {

        poz = startPos.position;

        InvokeRepeating("Go", 2, 2);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Go()
    {
        GameObject newBut = Instantiate(ob, poz, transform.rotation) as GameObject;


    }
}
