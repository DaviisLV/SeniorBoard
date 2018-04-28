using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
  
        if (other.gameObject.tag == "Coin")
            Destroy(other.gameObject);
        if (other.gameObject.tag == "line")
            Destroy(other.gameObject);


    }
}
