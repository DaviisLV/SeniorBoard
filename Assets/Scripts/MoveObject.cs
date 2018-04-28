using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
    public bool move = true;
    public float speed = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (move)
        transform.position += Vector3.back * Time.deltaTime*speed;
        if (!move)
            transform.position += Vector3.up * Time.deltaTime*7;
    }

    public void stop()
    {
        move = false;   
    }
}
