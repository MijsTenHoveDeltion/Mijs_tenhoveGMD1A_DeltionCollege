using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coffie : Food
{
	public int energie;

	public override void Eating()
	{
		base.Eating();
		eat = 2;
		print(eat);
	}
}
