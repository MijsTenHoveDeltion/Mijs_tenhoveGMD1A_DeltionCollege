using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
	public Text text;
	public Item item;
	public Image image1;
	public Image imageDrag;
	public GameObject followIm;
	public GameObject onOf;
	
	public void Start()
	{
		onOf.SetActive (false);
		text.enabled = (false);
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
			imageDrag.sprite = null;
			onOf.SetActive(false);
		}
	}

	public void ImageEnter()
	{
		if (image1.GetComponent<Image>().sprite != null)
		{
			text.enabled = (true);
			text.text = item.stringetje;
			text.text = item.textI.text;	
		}		
	}
	public void ImageExit()
	{
		text.enabled = (false);
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
			Slot test = image1.GetComponent<Slot>();
			Slot test2 = imageDrag.GetComponent<Slot>();
			test.item = test2.item;

			image1.GetComponent<Image>().sprite = imageDrag.sprite;
			imageDrag.sprite = null;
			imageDrag.GetComponent<Slot>().item = null;
			onOf.SetActive(false);
		}
	}
}






