using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopper : MonoBehaviour
{

    public float length;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject,length);

        }
    }
}
