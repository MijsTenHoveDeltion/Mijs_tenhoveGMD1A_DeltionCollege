﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munten : MonoBehaviour {



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
        }
    }
}