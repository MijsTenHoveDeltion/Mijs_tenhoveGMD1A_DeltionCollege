using UnityEngine;
using System.Collections;

public class Ballaf : MonoBehaviour
{
    public float PouwerUp;
    public float PouwerMaxUp = 1.5f;
    public bool pressed = false;
    public int MaxForse = 1000;
    public Vector3 force = new Vector3(0, 0, 100);
    public Rigidbody ball;


    //
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            PouwerUp = 0;
            pressed = true;
            ball.AddForce(force * MaxForse);
        }
        if (Input.GetButtonUp("Jump"))
        {
            pressed = false;
            print(PouwerUp);
         

        }
        if (pressed == true && PouwerUp < PouwerMaxUp)
        {
            PouwerUp = PouwerUp + Time.deltaTime * 100;
            // GetComponent<Rigidbody>().AddTorque
            //  (transform.forward * PouwerMaxUp * Time.deltaTime, ForceMode.Impulse);
            print("iets");
          
            
                }

        }



    }
