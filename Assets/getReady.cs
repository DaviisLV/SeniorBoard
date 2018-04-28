using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getReady : MonoBehaviour {


    public BoardPlacment bp;
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
       // text.text = bp.GetHitCount();
    }
}
