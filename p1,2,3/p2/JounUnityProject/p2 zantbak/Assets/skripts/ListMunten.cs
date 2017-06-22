using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ListMunten : MonoBehaviour {
	public List < GameObject > o = new List< GameObject > ();
	public List <bool> b = new List <bool> ();
	public GameObject munt; 
	public bool runloop;




	// Use this for initialization
	void Start () 
	{
		
	}


	void Update ()
	{
		if (runloop == true) {
			loop ();
		}
	}

	void loop ()
	{

		for (int i = 0; i < o.Count; i++) 
		{
			if (o [i].GetComponent<Munten> ().hit == true) 
			{ 
				o [i].GetComponent<MeshRenderer> ().enabled = false;
				b [i] = true;

			}
			runloop = false;
		}	

	}

}
