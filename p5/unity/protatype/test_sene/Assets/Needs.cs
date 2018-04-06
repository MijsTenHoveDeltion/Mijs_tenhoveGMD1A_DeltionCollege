using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needs : MonoBehaviour
{
	public string name ;
	public int fill;
	public float time;

	public void Start()
	{
		PrintBace();
	}


	public void PrintBace()
	{
		print( "name"+name);
		print("age"+fill);
		print("time"+time);

	}
	
	
}
