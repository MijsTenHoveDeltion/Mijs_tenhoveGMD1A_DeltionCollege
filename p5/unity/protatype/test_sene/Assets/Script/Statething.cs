using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statething : MonoBehaviour
{
	public enum DeEnum
	{
		walking,
		ET,
		EN,
		WC,
	}
	public DeEnum ED;

	public void Update()
	{
			switch (ED)
			{
			case DeEnum.WC:
				print("hygne");
				break;

			case DeEnum.EN:
				print("laap");
				break;

			case DeEnum.ET:
				print("eten");
				break;

			case DeEnum.walking:
				print("walking");
				break;
		}

	}
		
}
