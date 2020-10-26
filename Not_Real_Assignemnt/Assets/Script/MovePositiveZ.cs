﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePositiveZ : MonoBehaviour
{
    public GameObject childObject;
    
    float ForwardSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {

        if (transform.position.z > 19)
        {
            Destroy(gameObject);
        }
        else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * ForwardSpeed);
        }

        childObject.transform.Rotate(new Vector3(0,2,0));
    }
}
