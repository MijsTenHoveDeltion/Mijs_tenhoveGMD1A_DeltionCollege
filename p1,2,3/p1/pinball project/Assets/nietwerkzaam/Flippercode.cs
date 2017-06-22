using UnityEngine;
using System.Collections;

public class Flippercode : MonoBehaviour {
    public bool activateFliper;
    public bool activateFliperback;
    public float timer = 0;
    public GameObject flipperpovivot;
    public Rigidbody rb;


    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer == 0.00f && Input.GetKeyDown(KeyCode.RightShift))
          
        {
            activateFliper = true;
        }
        if (timer >= 0.00f)
        {
            activateFliperback = false;

            //Ballaf.AddForce(-10, 0, 3);
        }
        if (activateFliper == true)
        {
            transform.RotateAround(transform.position, flipperpovivot.transform.forward, -800 * Time.deltaTime);

        }
    }

        public void flexedUpdate ()
            {

       
        if ( timer == 0.00f && activateFliperback == false )
            
        {
            transform.RotateAround(transform.position,flipperpovivot.transform.forward,800 * Time.deltaTime);
            timer = timer + Time.deltaTime;
        }
        }
    }
