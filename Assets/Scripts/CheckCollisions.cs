using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollisions : MonoBehaviour {

    private int _hitCount = 0;

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Coin")
        {
            _hitCount++;
            Destroy(other.gameObject);
            Debug.Log(_hitCount);

        }
        
    }

    public string GetHitCount()
    {
        return _hitCount.ToString();
    }
}
