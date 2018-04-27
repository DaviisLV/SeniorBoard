using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlacment : MonoBehaviour {

    public GameObject Board;
    public GameObject ControllerLeft;
    public GameObject ControllerRight;

	void Start () {
        GetBoardPosition();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void GetBoardPosition()
    {
       Board.transform.position = ControllerLeft.transform.position + (ControllerRight.transform.position - ControllerLeft.transform.position) / 2;

        Debug.Log(ControllerRight.transform.position);
        Debug.Log(ControllerLeft.transform.position);
        Debug.Log(Board.transform.position);
    }

}
