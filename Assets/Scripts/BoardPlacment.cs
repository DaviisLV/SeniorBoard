using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlacment : MonoBehaviour
{
    public GameObject Box;
        
    public GameObject Board;
    public GameObject ControllerLeft;
    public GameObject ControllerRight;
    public GameObject Head;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        SetBoardPosition();
        SetBoxPoz();
    }

    private void FixedUpdate()
    {
        //   ShowControllerPoz();
    }

    private void SetBoardPosition()
    {

        float pozX = ControllerLeft.transform.position.x + (ControllerRight.transform.position.x - ControllerLeft.transform.position.x) / 2;
        float pozZ = ControllerLeft.transform.position.z + (ControllerRight.transform.position.z - ControllerLeft.transform.position.z) / 2;
        float pozY = ControllerLeft.transform.position.y;

        Board.transform.position = new Vector3(pozX, pozY, pozZ);
    }

    private void SetBoxPoz()
    {

        Box.transform.position = new Vector3(Board.transform.position.x+5, Board.transform.position.y, Board.transform.position.z);  

    }
    private void ShowControllerPoz()
    {
        Debug.Log("Right X = " + ControllerRight.transform.position.x + "Right Z = " + ControllerRight.transform.position.z);
        Debug.Log("Left X = " + ControllerLeft.transform.position.x + "Left Z = " + ControllerLeft.transform.position.z);
    }

}
