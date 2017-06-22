using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	public List<GameObject> g;
	public int gridWith = 5;
	public int grithHight = 7;
	public int gridPosition = 1;
	public int rborder;
	public int lborder; 

	public float timer;
	public Vector3 myPosision;

	void Start()
	{
		rborder = gridWith;
		timer = 1; 
		myPosision = gameObject.transform.position;
		g [gridPosition] = gameObject;
		rborder = gridWith;  
		//lborder >= 0; 
		//lborder <= 1; 
	


	}


	void Update()
	{
		timer-=Time.deltaTime; 
		if (timer <= 0 )
		{
			timer = 1;

			if ( gridPosition + gridWith < gridWith * grithHight && gridPosition + gridWith <= g.Count && g [gridPosition + gridWith] == null) 
			{
				rborder += gridWith;
				lborder += gridWith;
				myPosision.y -= 1;
				gameObject.transform.position = myPosision;
				g [gridPosition] = null;
				g [gridPosition += gridWith] = gameObject;

			}
		}

		if (Input.GetButtonDown ("R") && (g [gridPosition + 1] == null) && ( gridPosition + 1 < rborder))
		{
			
			myPosision.x -= 1;
			gameObject.transform.position = myPosision;
			g [gridPosition] = null;
			g [gridPosition += 1] = gameObject;
		}
		if (Input.GetButtonDown ("L") && ( gridPosition - 1 > lborder) && (g [gridPosition - 1] == null))
		{
			myPosision.x += 1;
			gameObject.transform.position = myPosision;
			g [gridPosition] = null;
			g [gridPosition -= 1] = gameObject;

		}


	}
}