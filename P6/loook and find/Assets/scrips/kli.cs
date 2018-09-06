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
	public GameObject oblist;

	public GameObject ps;

	void Start()
	{
		ps.SetActive(false);

	}

	public void OnMouseDown()
	{
		int index = 0;
		menus.SetNull(oblist);
		Debug.Log(imagename);
		Destroy(ob);
		Destroy(imagename);
		ps.SetActive(true);

	/*	for (int i = 0; i < menus.partical.Count; i++)
			{
			if (menus.partical[i] == null)
			{
				print("part is snull");
				//Destroy(partical[i]);
				menus.partical.RemoveAt(i);
			}
		}
		//tacking.kliks += 1;
*/
	}
}
