using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class Hint : MonoBehaviour
{
	public Image gm;
	public Color green;
	public Color white;
	public bool repead = false;

	public bool klikbole;

	// Use this for initialization
	void Start()
	{
		
		gm.color = white;
	}

	// Update is called once per frame
	void Update()
	{
		StartCoroutine("Waitforasecond");

	}
	IEnumerator Waitforasecond()
	{
		yield return new WaitForSeconds(10);


		gm.color =green;
		klikbole = true;
		print("yaas");
	}


}
