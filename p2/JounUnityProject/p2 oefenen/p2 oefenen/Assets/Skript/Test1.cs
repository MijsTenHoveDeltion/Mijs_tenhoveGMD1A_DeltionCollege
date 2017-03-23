using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour {
    public float bedrag;

  public void Start ()
    {
        bedrag = Normaal(bedrag);
    }

    float Normaal (float bereken)
    {
        bereken *= 1.21f;
        return bereken;
    }
}

