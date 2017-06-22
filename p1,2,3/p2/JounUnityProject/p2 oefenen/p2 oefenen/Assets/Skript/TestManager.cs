using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour {
    public static TestManager testManager;

	// Use this for initialization
	void Start () {

        DontDestroyOnLoad(transform.gameObject);
        if (testManager == null)
        {
            testManager = this;
        }
        else if (testManager != this)
                {
            Destroy(gameObject);
        }

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
