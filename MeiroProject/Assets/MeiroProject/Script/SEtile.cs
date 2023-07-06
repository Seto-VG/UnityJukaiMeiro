using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEtile : MonoBehaviour
{
    public AudioClip sound1;
    public  float length;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ðŽæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject, length);
           
            audioSource.PlayOneShot(sound1);

        }
    }



}
