using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractViertal : MonoBehaviour
{
	 abstract public void Hoooi();
	// staat niks in moet worden override

	public virtual void Doei()
	{
		
		//deze uitvoeren tenzij je een override 
	}
}
