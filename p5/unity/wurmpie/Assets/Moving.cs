using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
	public GameObject gm;
	public float speed;
	public float lookfast = 1.0f;
	private Transform owntransform;
	//public float minsensitivity = 30f;
	public float turn= 90f;


	// Use this for initialization
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{

		Vector2 fast = new Vector2(speed* Time.deltaTime, 0) ;
		transform.Translate(speed, 0, 0);


		if (Input.GetKeyDown("w") && gm.transform.localRotation != Quaternion.Euler(0.0f, 0.0f, -90.0f))  //Quaternion.Euler(0,0,-90)); 
		{
			gm.transform.localRotation = Quaternion.Euler(0, 0, 90);
		}
		if (Input.GetKeyDown("a") && gm.transform.localRotation != Quaternion.Euler(00.0f, 00.0f, 00.0f))
		{
			gm.transform.localRotation = Quaternion.Euler(0, 0, 180);
		}
		if (Input.GetKeyDown("s") && gm.transform.localRotation != Quaternion.Euler(0.0f, 0.0f, 90.0f))
		{
			gm.transform.localRotation = Quaternion.Euler(0, 0, -90); ;
		}
		if (Input.GetKeyDown("d")&& gm.transform.localRotation != Quaternion.Euler(0.0f, 0.0f, 180.0f))
		{
			gm.transform.localRotation = Quaternion.Euler(0, 0, 0);
		}

	}
}


