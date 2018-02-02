using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : BasicNeed
{
	public int en;

	public void Engergie()
	{//om eating op te lateren komen zo als altijd maar ook on energie te krijgen van het eten
		base.Needing();
		needs.sl[1].value += en *Time.deltaTime;
	}
}
