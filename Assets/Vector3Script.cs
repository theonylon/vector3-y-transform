﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector3Script : MonoBehaviour
{
    public Vector3 miVector;
    public GameObject myObject;


    // Start is called before the first frame update
    void Start()
    {
        myObject.transform.position = miVector;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
