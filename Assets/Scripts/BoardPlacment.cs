using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlacment : MonoBehaviour
{
    public GameObject Box;
    public GameObject Tabel;
    public GameObject Board;
    public GameObject ControllerLeft;
    public GameObject ControllerRight;
    public GameObject Head;

    private Vector3 _headStartPoz;

    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        SetBoardPosition();
        SetBoxPoz();
    }


    private void SetTabelPosition()
    {
        Tabel.transform.position = new Vector3();
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

        Box.transform.position = new Vector3(Board.transform.position.x,_headStartPoz.y-2, Board.transform.position.z+1);  

    }
    public void GetHeadPosition()
    {
        _headStartPoz = Head.transform.position;
    }
  

}
