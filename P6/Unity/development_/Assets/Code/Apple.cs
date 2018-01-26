using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Food
{

	public override void Eating()
	{
		base.Eating();
		eat = 2;
		print(eat);
	}
}
