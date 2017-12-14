using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
	//public Text text;
	//public Item item;
	public Image image1;
	public Image imageDrag;
	public GameObject followIm;
	//public GameObject onOf;

	private void Update()
	{

		
		
	}


	public void Klikken()
	{
		if (Input.GetMouseButtonDown(0))
		{
			if (followIm = this.gameObject)
			{
				followIm.transform.position = Input.mousePosition;
			}

		}
			//followIm.transform.position = Input.mousePosition;
	}
	public void Dragging()
	{
		print("drag2");
	}

	public void OnDrop()
	{
		print("Drop");
	}
}
