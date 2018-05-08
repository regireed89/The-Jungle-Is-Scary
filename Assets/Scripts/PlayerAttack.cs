﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    public Animation lightAttack;
    public Animation heavyAttack;
    public float lightTimer;
    public float heavyTimer;
    public bool lightReady;
    public bool heavyReady;

    // Update is called once per frame
    void Update()
    {
        if (lightReady)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                lightAttack.Play();
                lightReady = false;
            }
        }

        if (!lightReady)
        {
            lightTimer += Time.deltaTime;
        }

        if (lightTimer >= lightAttack["HeavyAttack"].length)
        {
            
            //lightAttack.Rewind();         
            lightReady = true;
            lightTimer = 0;
        }


        if (heavyReady)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                heavyAttack.Play();
                heavyReady = false;
            }
        }

        if (!heavyReady)
        {
            heavyTimer += Time.deltaTime;
        }

        if (heavyTimer >= heavyAttack["HeavyAttack"].length)
        {
            heavyTimer = 0;
            heavyAttack.Rewind();         
            heavyReady = true;
        }
    }
}