using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour {

    public static Gamemanager instinse = null;
    public GameObject player1;
	public Canvas gameOver;
    public int test;
    // Use this for initialization
    void Start()
    {
		gameOver.enabled = false;
        DontDestroyOnLoad(transform.gameObject);

        if (instinse == null)
        {
            instinse = this;
        }
        else if (instinse != this)
        {
            Destroy(gameObject);

        }
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    public void Die()
    {
        Destroy(player1);
        print("test");
		gameOver.enabled = true;
    }

	public void reload()
	{
		Application.LoadLevel("zandbak");
		gameOver.enabled = true;
	}
}
