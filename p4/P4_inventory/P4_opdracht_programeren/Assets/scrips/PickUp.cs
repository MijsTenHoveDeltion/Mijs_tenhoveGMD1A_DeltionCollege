using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
	public Slot slot;
	public Sprite gm;
	public Item itemS;
	public Image imagePU;

	public void Update()
	{
		imagePU.GetComponent<Image>().sprite = gm;
		gm = itemS.sprite;
	}

	public void Dragg()
	{
		if (imagePU.GetComponent<Image>().sprite != null)
		{
			print("b");
			slot.imageDrag.GetComponent<Image>().sprite= gm ;
			slot.onOf.SetActive(true);
		}
	}

	public void Droppen()
	{


	}
	// waneer je gm oppakt dan destroy gm en full slot.image 

}
