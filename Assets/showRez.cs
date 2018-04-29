using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showRez : MonoBehaviour
{
    public CheckCollisions cc;
    // Use this for initialization
    Text text;
    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = cc.cc();
    }
}
