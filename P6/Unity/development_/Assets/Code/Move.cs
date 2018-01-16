using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
	public GameManager gm;
	public NavMeshAgent nm;
	public Transform t;

	public void Start()
	{
		print("movestart");
		nm = this.GetComponent<NavMeshAgent>();
		if (nm == null)
		{
			Debug.LogError("nope" + gameObject.name);
		}
		else
		{
			Moving();
		}
	}
	
	public void Moving()
	{
		;
		if (nm != null)
		{
			Vector3 trans = t.transform.position;
			nm.SetDestination(trans);
		}
	}

}
