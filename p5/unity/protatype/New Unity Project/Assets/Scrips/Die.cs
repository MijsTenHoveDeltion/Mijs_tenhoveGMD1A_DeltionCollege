﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Die : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.CompareTag("water"))
		{
			SceneManager.LoadScene("zombie");
		}
		if (other.gameObject.CompareTag("zombie"))
		{
			SceneManager.LoadScene("zombie");
		}
	}
}