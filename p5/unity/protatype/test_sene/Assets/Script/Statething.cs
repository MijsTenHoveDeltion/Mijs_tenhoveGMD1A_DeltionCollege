using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statething : MonoBehaviour
{
	// de enum 
	public enum DeEnum
	{
		nothing,
		walking,
		ET,
		EN,
		WC,
	}
	public DeEnum ED;

	public void Start()
	{
		ED = DeEnum.nothing;
	}

	public void Update()
	{
		//zorgt voor dat ik de enum kan veranderen
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

			default:
				print("defold");
				break;
		}

	}
		
}
