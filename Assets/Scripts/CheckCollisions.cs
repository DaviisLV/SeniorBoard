using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CheckCollisions : MonoBehaviour {

    public AudioClip impact;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private int _hitCount = 0;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("HIT");
        if (other.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(impact);
            _hitCount++;
            other.gameObject.GetComponent<MoveObject>().stop();
            Destroy(other.gameObject,0.7f);

            Debug.Log(_hitCount);

        }
        
    }

    public string GetHitCount()
    {
        return "Punkti: "+_hitCount.ToString();
    }
    public string cc()
    {
        return _hitCount.ToString();
    }
}
