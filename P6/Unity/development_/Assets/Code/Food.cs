using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{

	public int eat;

	public virtual void Eating()
	{
		eat = 1; 
		print(eat);
	}


}
