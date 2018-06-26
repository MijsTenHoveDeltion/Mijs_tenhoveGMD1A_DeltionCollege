using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kli : MonoBehaviour
{
	public bool boo;
	public GameObject imagename;
	public GameObject ob;
	public Tacking tacking;
	public Menus menus;

	public GameObject ps;

	void Start()
	{
		ps.SetActive( false);
		
	}

	public void OnMouseDown()
	{

		Debug.Log(imagename);
		Destroy(ob);
		Destroy(imagename);
		ps.SetActive(true);

		foreach (var item in menus.partical)
		{

			menus.partical.Remove(item);
		}
		tacking.kliks += 1;
	
		
		
	}

}
