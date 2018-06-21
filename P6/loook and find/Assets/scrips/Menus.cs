using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
	public Color hover;
	public Color white;
	public SpriteRenderer sp;

	public GameObject canvas;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void OnMouseOver()
	{
		sp.color = hover;
		print("werkt");
	}
	public void OnMouseExit()
	{
		sp.color = white;
		print("werkt");
	}

	public void reload()
	{
		SceneManager.LoadScene(0);

	}

	public void Play()
	{
		canvas.SetActive(false);
		canvas.SetActive(true);
	}
	public void Quit()
	{
		Application.Quit();
	}
}
