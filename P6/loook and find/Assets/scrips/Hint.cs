using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hint : MonoBehaviour
{
	public SpriteRenderer gm;
	public Color green;
	public Color white;
	//private SpriteRenderer spriteR;

	// Use this for initialization
	void Start()
	{
		//spriteR = gameObject.GetComponent<SpriteRenderer>();

		gm.color = green;
	}

	// Update is called once per frame
	void Update()
	{
		
	}


}
