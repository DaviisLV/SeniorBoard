using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour {

    private int _hitCount = 0;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        if (other.gameObject.tag == "Coin")
        {
            _hitCount++;
            other.gameObject.GetComponent<MoveObject>().stop();
            Destroy(other.gameObject,0.7f);

            Debug.Log(_hitCount);

        }
        
    }

    public string GetHitCount()
    {
        return "Trāpijumi: "+_hitCount.ToString();
    }
}
