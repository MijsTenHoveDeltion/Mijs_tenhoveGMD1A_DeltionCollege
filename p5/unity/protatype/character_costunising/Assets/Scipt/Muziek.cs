using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Muziek : MonoBehaviour
{
	public GameObject m_MyAudioSource;

	public bool m_Play;
	bool m_ToggleChange;

	//public Image on;
	//public Image of;

	void Update()
	{
		Doewat();
		
	}

	void Doewat()
	{
		if (m_Play == true)
		{
			m_MyAudioSource.SetActive(true); 
		}

		if (m_Play == false)
		{
			m_MyAudioSource.SetActive(false);
		}
	}

	public void Aan()
	{

		if (m_Play == true)
		{
			m_Play = false;
			
		}
		else 
		{
			m_Play = true;

		}
	}
}
