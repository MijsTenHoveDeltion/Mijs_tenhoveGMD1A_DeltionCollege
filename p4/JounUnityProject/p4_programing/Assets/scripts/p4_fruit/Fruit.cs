using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Fruit : MonoBehaviour
{

    public bool rijp;
    public bool giftig;
    public bool energy;
    public bool pellbaar;



	// Use this for initialization
	void Start () 
	{
		
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	public virtual void Pel()
	{
		print ( " ik sta in fruit");
		//mag override worden
	}

	public abstract void Pluk ();
	// moet override worden 
}

