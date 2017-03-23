using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Co : MonoBehaviour
{
    float time = 1; 


	// Use this for initialization
	void Start ()
    {
        StartCoroutine(Test(time));
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public IEnumerator Test (float f)
    {
        yield return new WaitForSeconds(f);
        print("hot");

    }
}
