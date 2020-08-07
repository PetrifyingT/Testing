﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet2script : MonoBehaviour
{
    private float shotTimer = 0.0f;
    public GameObject bullet2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shotTimer += Time.deltaTime;
        if (shotTimer > 2)
        {
            Instantiate(bullet2, this.transform.position, this.transform.rotation);
            shotTimer = 0;
        }
    }
}
