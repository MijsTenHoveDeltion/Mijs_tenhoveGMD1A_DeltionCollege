using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_UFO : MonoBehaviour {
    public Animator animator;

	// Use this for initialization
	void Start ()
    {
        animator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update ()
    {
        animator.SetFloat("horizontel", Input.GetAxis("horizontal"));
        animator.SetFloat("vertical", Input.GetAxis("vertical"));

    }
}
