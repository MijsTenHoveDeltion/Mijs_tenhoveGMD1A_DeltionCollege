using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
	public float damage;
	public float range;

	public GameObject gm;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shooting();
		}

	}

	void Shooting()
	{
		RaycastHit hit;
		if (Physics.Raycast(gm.transform.position, gm.transform.forward, out hit, range))
		{
			Debug.Log(hit.transform.name);
		}

	}
}
