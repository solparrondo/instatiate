﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiator : MonoBehaviour
{

    public GameObject objectToClone;

    public void Multipilicar()
    {
        int counter = 0;
        while (counter < 3)
        {

            Instantiate(objectToClone);
            counter++;

        }
    }
        // Start is called before the first frame update
        void Start()
    {

     
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
