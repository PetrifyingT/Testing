﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meowmeow : MonoBehaviour
{


    public float speed = 20;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
