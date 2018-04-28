using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObjects : MonoBehaviour {

    public GameObject ob;
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
        GameObject newBut = Instantiate(ob, startPos.position, transform.rotation) as GameObject;


    }
}
