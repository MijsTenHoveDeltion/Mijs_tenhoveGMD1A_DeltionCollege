using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMent : MonoBehaviour {
    public float horizontal;
    public float vertical;
    public float vert;
    public float hor;
    public float turnSpeed;
    public float speed;
    public float updownRange;
    public float vertRot;


	void Start () {
		
	}
	

	void Update () {
        horizontal = Input.GetAxis("Mouse X") * turnSpeed * Time.deltaTime;
        vertical = Input.GetAxis("Mouse Y") * turnSpeed * Time.deltaTime;
        vert = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        hor = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.Translate(hor, 0, vert);
        transform.Rotate(0, horizontal, 0);
        vertRot -= vertical;
        print(vertRot);
        vertRot = Mathf.Clamp(vertRot, -updownRange, updownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(vertRot, 0, 0);

    }
}
