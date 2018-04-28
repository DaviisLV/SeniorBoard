﻿using System.Collections;
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
    public int PowerOfMove = 5;
    public float BoxOffset = 0.9f;

    Vector3 corentPoz,lastPoz;

    Vector3 MidlePoint;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
      //  SetBoxPoz();
        Board.transform.position += corentPoz;
    }

    private void LateUpdate()
    {
        corentPoz = MidlePoint - lastPoz;
      
  
    }

   

    private void SetBoardPosition()
    {

        float pozX = ControllerLeft.transform.position.x + (ControllerRight.transform.position.x - ControllerLeft.transform.position.x) / 2;
        float pozZ = ControllerLeft.transform.position.z + (ControllerRight.transform.position.z - ControllerLeft.transform.position.z) / 2;
        float pozY = ControllerLeft.transform.position.y;

        MidlePoint = new Vector3(pozX, pozY, pozZ);
        lastPoz = MidlePoint;
        Board.transform.position = MidlePoint;

    }

    private void SetBoxPoz()
    {

        Box.transform.position = new Vector3(Board.transform.position.x,_headStartPoz.y-BoxOffset, Board.transform.position.z+0.4f);  

    }
    public void GetHeadPosition()
    {
       
        _headStartPoz = Head.transform.position;
        SetBoardPosition();
    }
  

}
