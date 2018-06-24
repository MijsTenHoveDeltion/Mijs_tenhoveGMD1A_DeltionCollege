using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Hint : MonoBehaviour
{
	public float speed =1f;
	//public SpriteRenderer gm;
	public Color green;
	public Color white;
	public bool repead = false;

	float starttime;
	

	// Use this for initialization
	void Start()
	{
		starttime = Time.time;
		//gm.color = green;
	}

	// Update is called once per frame
	void Update()
	{
		if (!repead)
		{
			print("1");
			float t = (Time.deltaTime - starttime) * speed;
			GetComponent<Image>().color = Color.Lerp(green, white, t);
				
		}
		else
		{
			float t = ( Mathf.Sin(Time.deltaTime - starttime)* speed);
			GetComponent<Image>().color = Color.Lerp(green, white, t);
		}
		print("2");

	}


}
