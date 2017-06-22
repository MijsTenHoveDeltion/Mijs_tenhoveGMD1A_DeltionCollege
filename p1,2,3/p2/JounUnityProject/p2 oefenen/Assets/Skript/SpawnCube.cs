using UnityEngine;
using System.Collections;

public class SpawnCube : MonoBehaviour {
    public GameObject CubePrefab;
    public GameObject SpawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	

	void Update () {
        if (Input.GetButton("Jump"))
        {
            Vector3 spawnposision = SpawnPoint.transform.position;
            Instantiate(CubePrefab,spawnposision,Quaternion.identity);

        }

	
	}
}
