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
       
        StartCoroutine("CreateObjects");
    }

    IEnumerator CreateObjects()
    {
        GameObject newBut = Instantiate(ob, startPos.position, transform.rotation) as GameObject;

        yield return new WaitForSeconds(5);

        GameObject newBut2 = Instantiate(ob,startPos.position, transform.rotation) as GameObject;
    }
}
