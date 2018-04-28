using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardPlacment : MonoBehaviour
{
    public GameObject path;
    public GameObject Car;
    public GameObject ControllerLeft;
    public GameObject ControllerRight;
    public GameObject Head;

    private Vector3 _headStartPoz;
    public int PowerOfMove = 5;
    public float BoxOffset = 0.9f;
    public float carpozOffset = -0.4f;
    public float pathOffset = 0;
    bool ready = false;
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (ready)
        SetBoardPosition();
 
    }



    private void SetBoardPosition()
    {

        float pozX = ControllerLeft.transform.position.x + (ControllerRight.transform.position.x - ControllerLeft.transform.position.x) / 2;
        float pozZ = ControllerLeft.transform.position.z + (ControllerRight.transform.position.z - ControllerLeft.transform.position.z) / 2;
        float pozY = _headStartPoz.y + carpozOffset;

        Car.transform.position = new Vector3(pozX*PowerOfMove, pozY, pozZ);
    }

    
    public void GetHeadPosition()
    {
        Car.SetActive(true);
        path.SetActive(true);
        _headStartPoz = Head.transform.position;
        path.transform.position = new Vector3(path.transform.position.x, _headStartPoz.y + pathOffset, path.transform.position.z);
       
        ready = true;

    }
  

}
