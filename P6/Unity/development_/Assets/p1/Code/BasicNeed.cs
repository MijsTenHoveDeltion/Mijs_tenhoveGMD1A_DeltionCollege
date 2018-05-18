using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicNeed : MonoBehaviour
{
	public Needs needs;

	public int eat;

	public virtual void Needing()
	{// om de slider die lager is dan 1 om hoog te laten gaan
		needs.slider.value += eat * Time.deltaTime;
	}
}

