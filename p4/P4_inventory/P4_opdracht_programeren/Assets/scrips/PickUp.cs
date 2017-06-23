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
	public Text textPU;

	public void Update()
	{
		imagePU.GetComponent<Image>().sprite = gm;
		gm = itemS.sprite;
		textPU = itemS.textI;
	}

	public void Dragg()
	{
		if (imagePU.GetComponent<Image>().sprite != null)
		{
			slot.imageDrag.GetComponent<Image>().sprite= gm;
			slot.imageDrag.GetComponent<Slot>().item = itemS;

			slot.onOf.SetActive(true);
		}
	}
}
