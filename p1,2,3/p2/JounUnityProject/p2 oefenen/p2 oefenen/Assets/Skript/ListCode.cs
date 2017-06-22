using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCode : MonoBehaviour {
    public List<bool> b = new List<bool>();
    
    // list is maar foor 1 tipe of bool of float enz 
	// Use this for initialization
	void Start () {
        b[1] = true;
        b[4] = true;
        b[7] = true;

        for (int i = 0; i < b.Count; i++)
        {

            if (b[i] == true)
                {
                print( b[i]);
            }
            
        }
    }
	
	// Update is called once per frame
	void Update () {
        
	}
}
