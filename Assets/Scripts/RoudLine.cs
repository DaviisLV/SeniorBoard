using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoudLine : MonoBehaviour {

    public GameObject line;
    public Transform startPos;
    private Transform dropPoz;
	
	// Update is called once per frame
	void Update () {
		
	}

    void Start()
    {

        InvokeRepeating("CreateObjects", 2,2);
    }

   public void CreateObjects()
    {
        GameObject newBut = Instantiate(line) as GameObject;


    }
}
