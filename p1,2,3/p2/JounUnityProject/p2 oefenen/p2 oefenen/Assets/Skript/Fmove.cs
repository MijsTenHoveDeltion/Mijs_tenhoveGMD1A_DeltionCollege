using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fmove : MonoBehaviour {

    public float fastspeed = 5.0f;
    


    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButton("Horizontal")) * fastspeed ; 
        float vooruit = (Input.GetAxis("Vertical")) * fastspeed;
        float opzij = (Input.GetAxis("Horizontal")) * fastspeed;

        Vector3 speed = new Vector3(opzij, 0 , vooruit);

        speed = transform.rotation * speed;


        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);


    }
}
