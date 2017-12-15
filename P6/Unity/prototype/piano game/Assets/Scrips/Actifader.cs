using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actifader : MonoBehaviour
{
	public string key;
	public GameObject note;
	bool boo;

	private void Start()
	{
		//sprit = GetComponent<SpriteRenderer>();

	}

	void Update()
	{
		if (Input.GetKeyDown(key))
		{
			StartCoroutine(Colors());	
		}
		else
		{
			GetComponent<SpriteRenderer>().color = Color.white;
		}

		if (Input.GetKeyDown(key) && boo)
		{
			Destroy(note);
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
		yield return new WaitForSeconds(0.1f);
		GetComponent<SpriteRenderer>().color = Color.red;
	}



}



