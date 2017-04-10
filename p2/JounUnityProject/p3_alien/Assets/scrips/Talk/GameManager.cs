using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Animator anime;

	
	void Start ()
    {
        anime.SetBool("loop", true);
	}
	

	void Update () {
		
	}
}
