using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actifader : MonoBehaviour
{
	public string key;
	public GameObject note;
	public bool boo;

	void Update ()
	{
		if (Input.GetKeyDown(key)&&boo)
		{
		
			Destroy(note);
		}
	}
	public void  OnCollisionEnter2D(Collision2D coll)
	{	boo = true;
		if (coll.gameObject.tag == "note")
		{
			note = coll.gameObject;
			
		}
		
	}

	public void OnCollisionExit2D(Collision2D coll)
	{
		boo = false;
	}

}



