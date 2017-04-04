using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListKey : MonoBehaviour
{
    public List<GameObject> opje = new List<GameObject>();
    public List<bool> apje = new List<bool>();
    public GameObject kay;
    public bool runloop; 

    public void OnCollisionEnter(Collision other)
    {

    }
    void Start ()
    {
        if (runloop == true)
        {
            loop();
        }
    }

    void loop ()
    {
        for (int i = 0; i < opje.Count; ++i )
        {
            if (opje [i].GetComponent<Keys> ().hit == true)
            {
                opje [i].GetComponent<MeshRenderer>().enabled = false;
                    apje[i] = true;
            }
        }
    }
}

