using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontrrr : MonoBehaviour {


	private void OnTriggerEnter(Collider other)
	{
		print("a");
	}
	private void OnTriggerStay(Collider other)
	{
		print("b");
	}
}
