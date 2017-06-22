using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

    public float forceUp;
    public float force = 0;
    public bool forcebutton = false;
    public Rigidbody schiet;
    public Vector3 richting;
    
       void Update()
    {  
        if ( Input.GetButton("Jump"))
        {
            //als je jump/ space indrukt word het bool waaar en in werking gebracht 
            forceUp = 0;
            forcebutton = true;
            schiet.AddForce(richting* -8000);
        }
    }

    public void OnCollisionEnter(Collision collision)
{
    // hoek van inval   

    richting = collision.contacts[0].normal;
    schiet.AddForce(richting * -8000);

    if (collision.gameObject.tag == "launcher")
    {
        // hoek van uitval die schiets
        forcebutton = true;
        schiet.AddForce(richting * -8000);
    }
}
}