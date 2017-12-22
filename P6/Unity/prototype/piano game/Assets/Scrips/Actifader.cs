using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Actifader : MonoBehaviour
{
	public string key;
	public GameObject note;
	bool boo;

	public Score sk;
	public int points;
	public AudioSource sound;
	public Color collor;
	public AudioSource boooh;
	public AudioSource aplouse;

	public Slider slider;
	public float floatSlider;
	
	

	private void Start()
	{
		sound = GetComponent<AudioSource>();
		slider.value = 0;
	}

	void Update()
	{ 
	
		if (Input.GetKeyDown(key))
		{
			StartCoroutine(Colors());
			KaySound();
			
		}
		else
		{
			if (Input.GetKeyUp(key))
			{
				GetComponent<SpriteRenderer>().color = Color.white;
			}
			
		}

		if (Input.GetKeyDown(key) && boo)
		{
			Points();
			Destroy(note);
			
		}
	}

	public void Points()
	{
		sk.counit += points;
		slider.value += floatSlider;

		if (slider.value == 1f)
		{
			sk.counit += points;
			aplouse.Play();
		}
	}


	public void OnTriggerStay2D(Collider2D coll)
	{

		boo = true;
		if (coll.gameObject.tag == "note")
		{
			note = coll.gameObject;

		}
	
	}

	public void OnTriggerExit2D(Collider2D collision)
	{
		boo = false;
	}


	IEnumerator Colors()
	{
		GetComponent<SpriteRenderer>().color = collor;
		yield return new WaitForSeconds(0.2f);
		
	}

	public void KaySound()
	{
		sound.Play();
		if (boo == false)
		{
			if (sk.counit != 0)
			{
				sk.counit -= points;
				slider.value -= floatSlider;
			}
			if (sk.counit == 0)
			{
				print("boo");
				boooh.Play();
			}
			
		}
	}



}



