using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klik : MonoBehaviour {

    public float sec = 3f ;
    public bool aan;

	// Use this for initialization
	void Start () {
        aan = false;

   
	}
	
	// Update is called once per frame
	void OnMouseDown () {

        // timer in forloop met time.deltatime

          
            aan = true;
        if (gameObject.tag == ("1"))
        {
            print("t1");
            StartCoroutine(Blok(sec));
        }
        else if (gameObject.tag == ("2"))
        {
            print("t2");
            StartCoroutine(Blok(sec));
        }
        else if (gameObject.tag == ("3"))
        {
            print("t3");
            StartCoroutine(Blok(sec));
        }

    }
    public IEnumerator Blok (float f)
    {
        yield return new WaitForSeconds(f);
            
        print("lekker");
    }

}
