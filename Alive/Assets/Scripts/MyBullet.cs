﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBullet : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MyBullet")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}