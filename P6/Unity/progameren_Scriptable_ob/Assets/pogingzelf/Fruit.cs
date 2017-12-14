using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : ScriptableObject
{
	public bool boo;

	public virtual void Peel()
	{
		Debug.Log("ik ben fruit");
	}
}

