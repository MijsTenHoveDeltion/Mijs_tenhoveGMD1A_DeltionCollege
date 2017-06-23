using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryAanUit : MonoBehaviour
{
	public Canvas inventory;
	public bool invOn;

	private void Start()
	{
		inventory.enabled = false;
		invOn = false;
	}

	void Update ()
	{
		if (Input.GetButtonDown("E") && invOn == false)
		{
			inventory.enabled = true;
			invOn = true;
		}

		else if (Input.GetButtonDown("E") && invOn == true)
		{
			inventory.enabled = false;
			invOn = false;
		}
	}	
}
