using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tacking : MonoBehaviour
{
	public int kliks;
	public KeyCode mouseKlik;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown(mouseKlik))
		{
			if (kliks !=0)
			{
				kliks -= 1;

			}
			else
			{
				print("strop");
			}
			
		}
		
	}
}
