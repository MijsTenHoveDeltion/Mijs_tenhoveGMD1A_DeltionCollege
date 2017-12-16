using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Text countText;
	public int counit;

	// Use this for initialization
	void Start()
	{
		counit = 0;
		countText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update()
	{
		countText.text = "Score: " + counit;
	}
}
