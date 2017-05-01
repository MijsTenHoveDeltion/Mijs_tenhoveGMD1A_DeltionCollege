using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollTheBall : MonoBehaviour {
   
    
    public float speedH;
    public float speedV;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
            speedH = Input.GetAxis ("Horizontal");

        Vector3 v = (new Vector3(0, 0, speedH));

        rb.AddForce(v * speedH);





    }
}
