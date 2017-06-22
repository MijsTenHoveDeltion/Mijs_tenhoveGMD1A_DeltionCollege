using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munten : MonoBehaviour {
	public GameObject gamemaneger;
	public bool hit;

	void OnTriggerEnter(Collider other)
	{
		gamemaneger.GetComponent<ListMunten> ().runloop = true;
		hit = true;
	}

}