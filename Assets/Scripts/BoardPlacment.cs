using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlacment : MonoBehaviour {

    public GameObject Board;
    public GameObject ControllerLeft;
    public GameObject ControllerRight;

	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
		 SetBoardPosition();
	}

    private void FixedUpdate()
    {
        ShowControllerPoz();
    }

    private void SetBoardPosition()
    {
       Board.transform.position = ControllerLeft.transform.position + (ControllerRight.transform.position - ControllerLeft.transform.position) / 2;
    }

    private void ShowControllerPoz()
    {
        Debug.Log("Right X = "+ ControllerRight.transform.position.x+ "Right Z = " + ControllerRight.transform.position.z);
        Debug.Log("Left X = " + ControllerLeft.transform.position.x + "Left Z = " + ControllerLeft.transform.position.z);
    }

}
