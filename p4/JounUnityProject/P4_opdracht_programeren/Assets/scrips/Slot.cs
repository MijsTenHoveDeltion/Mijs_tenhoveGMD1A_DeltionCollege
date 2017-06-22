using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
	public Item item;
	public Image image1;
	public Image imageDrag;
	public GameObject followIm;
	public GameObject onOf;
	public ListImage listImag;
	
	public void Start()
	{
		onOf.SetActive (false);
	}

	private void Update()
	{
		if (followIm)
		{
			transform.position = Input.mousePosition;
		}
	}
	public void Klikken()
	{
		if (image1.GetComponent<Image>().sprite == null)
		{
			image1.GetComponent<Image>().sprite = imageDrag.sprite;
			listImag.plaatjes.Add(item.plaatje);
			imageDrag.sprite = null;
			onOf.SetActive(false);
		}
	}

	public void ImageEnter()
	{
	
	}
	public void ImageExit()
	{
	}
	public void Dragging()
	{
		if (image1.GetComponent<Image>().sprite != null)
		{
			
			imageDrag.sprite = image1.sprite;
			image1.sprite = null;
			onOf.SetActive(true);
		}
	}

	public void OnDrop()
	{
		if (image1.GetComponent<Image>().sprite == null)
		{
			image1.GetComponent<Image>().sprite = imageDrag.sprite;
			listImag.plaatjes.Add(item.plaatje);
			imageDrag.sprite = null;
			onOf.SetActive(false);
		}
	}
}






