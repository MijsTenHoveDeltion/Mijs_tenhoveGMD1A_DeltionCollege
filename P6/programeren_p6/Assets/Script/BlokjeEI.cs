using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokjeEI : MonoBehaviour
{
	public enum Noord
	{
		n,
		o,
		z,
		w,
	};

	public Noord noord;
	public GameObject gm;

	// Use this for initialization
	void Start()
	{
		//noord = Noord.n;
	}

	// Update is called once per frame
	void Update()
	{
		//if (Input.GetButtonDown("Fire1"))
		//   {
		//transform.rotation = Quaternion.Euler (new Vector3(0,0,(int)Noord.n));
		//  }

		if (noord == Noord.n)
		{
			//no = Noord.z;
			//print("1");
		}

		if (noord == Noord.z)
		{
			//no = Noord.n;
		//	print("2");
		}
		if (noord == Noord.o)
		{
			//no = Noord.w;
		//	print("3");
		}
		if (noord == Noord.w)
		{
			//no = Noord.o;
		//	print("4");
		}
	}

	Noord ReverseDirection(Noord no)
	{
		print("0");
		if (no == Noord.n)
		{
			//no = Noord.z;
			print("1");
		}

		 if (no == Noord.z)
		{
			//no = Noord.n;
			print("2");
		}
		 if (no == Noord.o)
		{
			//no = Noord.w;
			print("3");
		}
		 if (no == Noord.w)
		{
			//no = Noord.o;
			print("4");
		}
		return no;
	}
}
	