using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitHolder : MonoBehaviour
{
	public Fruit fruit;

	public void Start()
	{
		fruit.Peel();
	}
}
