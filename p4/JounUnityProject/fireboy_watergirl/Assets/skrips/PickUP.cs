using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUP : MonoBehaviour {

	public bool boletje;
	public GameObject gm;
	private void Start()
	{
		boletje = true;
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gm)
		{
			boletje = false;
			//other.gameObject.SetActive(false);
		}
	}
}
