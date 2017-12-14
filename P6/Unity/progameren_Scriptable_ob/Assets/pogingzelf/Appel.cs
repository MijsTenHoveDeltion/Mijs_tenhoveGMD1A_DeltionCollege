using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "appel", menuName = "Fruit/Appel", order = 1)]

public class Appel : Fruit
{
	public int intje;


	public override void Peel()
	{
		Debug.Log("ik ben appel");
    }
}
