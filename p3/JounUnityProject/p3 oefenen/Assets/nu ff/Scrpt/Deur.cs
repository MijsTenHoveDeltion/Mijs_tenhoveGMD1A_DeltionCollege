using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deur : MonoBehaviour {
    public List<GameObject> opje;
    public bool open;
    public int km;

	void Start () {
        open = false;

        opje = GameObject.FindGameObjectWithTag("ugh").GetComponent<ListKey>().opje;


	
	}
	
	// Update is called once per frame
	void Update () {

       

		
	}

    void OnCollisionEnter (Collision collision)
    {
        print("6");
        if (collision.gameObject.tag == "deur")
        {
            print("3");
            km = 0;

            for (int e = 0; e < opje.Count; ++e)
            {
                if (opje[e].tag == "key")
                {
                    km++;

                    print("4");

                }

                // als opje is 3kay dan doe bool op true
            }
            if (km >= 3)
            {
                print("5");
                open = true;
            }

        }
    }

}
