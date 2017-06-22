using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    public float movenentSpeed = 5.0f;
    public float mouseSensitivity = 5.0;

    float verticalRotation = 0;
    public float UpDouwnRange = 60.0f;
   

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // rotatie
        float rotLeftRight = Input.GetAxis("mouse X") * mouseSensitivity;
        transform.Rotate(0, rotLeftRight, 0);


        verticalRotation -= Input.GetAxis("Mouse Y") * mouseSensitivity;
        verticalRotation
	
	}
}
