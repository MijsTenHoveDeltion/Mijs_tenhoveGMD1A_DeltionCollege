using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pos : MonoBehaviour
{
	public GameObject gm;
	public NavMeshAgent nm;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		nm.SetDestination(gm.transform.position);
	}
}
