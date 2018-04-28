using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenereitObjects : MonoBehaviour {
    public Vector3[] path;
    public GameObject ob;
    public Transform startPos;
    Vector3 poz;
    // Use this for initialization

 
    void Start () {

        poz = startPos.position;

        //  InvokeRepeating("Go", 2, 2);
       // Go();
    }
	
	// Update is called once per frame
	void Update () {
     
	}

    public void Go()
    {
        for (int i = 0; i < path.Length; i++)
        {
            GameObject newBut = Instantiate(ob, path[i], transform.rotation) as GameObject;
            newBut.transform.parent = startPos;
            newBut.transform.position = path[i];
            Debug.Log(newBut.transform.position);
        }

    }
}
