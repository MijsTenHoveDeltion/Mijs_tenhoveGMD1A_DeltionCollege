using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokjeEI : MonoBehaviour
{
	public enum Noord
	{
		n =  90,
		o = -90,
		z = 180,
		w =  0
	};

	public Noord noord;
	public GameObject gm;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
			if (Input.GetButtonDown("Fire1"))
		    {
			transform.rotation = Quaternion.Euler (new Vector3(0,0,(int)Noord.n));
		    }
	}

	void Enum()
	{

	}


}
