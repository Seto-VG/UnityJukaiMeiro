using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public float speed = 100.0F;    // à⁄ìÆëÅÇ≥


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Inputed");

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");


        Vector2 direction = new Vector2(h, v).normalized;


            GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}