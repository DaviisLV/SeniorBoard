using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onDestroy : MonoBehaviour {

    public GameObject END;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnDestroy()
    {
        END.SetActive(true);
    }
}
