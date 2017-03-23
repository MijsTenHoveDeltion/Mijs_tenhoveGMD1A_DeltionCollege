using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaDead : MonoBehaviour {

    public Gamemanager script;
    //public GameObject box ; 

    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        script.test += 1;
	}

	void OnTriggerEnter () 
	{
     
        script.Die();
            
	}


}

