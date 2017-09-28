using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overschrijven : MonoBehaviour
{
	public ParticleSystem pSystem;
	ParticleSystem.Particle[] m_Particles;
	public LineRenderer lineRender;
	public GameObject gm;

	public int maxPart;
	public float startLife;
	public float startsize;
	public float maxDistence;
	public int proefInt;

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void Update()
	{
		/*	int maxparticals = particleSystemMainModule.maxparticals;
			if partecals == null || particless
			float distanceSqr = maxDistence * maxDistence;
			int pcount = pSystem.particleCount;
			for (int i = 0; i < pSystem.particleCount; i++)
			{
				Vector3 p1 = m_Particles[i].position;


				for (int j = i; j < pcount; j++)
				{
					Vector3 p2 = m_Particles[i].position;
					float dis = Vector3.SqrMagnitude(p1 - p2);
					if (distanceSqr <= maxDistence)
					{

					}
				}
			}
		*/
	}
}
