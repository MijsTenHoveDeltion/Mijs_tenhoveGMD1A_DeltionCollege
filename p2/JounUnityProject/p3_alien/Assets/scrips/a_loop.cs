using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_loop : MonoBehaviour
{
    public UIM_Talk uimtalk;
    public Animator anime;
    public GameObject go;
    public float f;
    public float f2;
    public bool stLoop;
    private Transform tv;
    public Canvas gesperkje; 

    void Start ()
    {  
        anime.SetBool("loop", true);
        stLoop = true;
 //     tv = go.transform;
        
    }

    void Update()
    {
        {
            if (stLoop == true)
            {
                transform.position = Vector3.MoveTowards(transform.position, (new Vector3(-4, 0.6f, -2)), f);


                //  transform.position = Vector3.MoveTowards(transform.position, (new Vector3(4, 0.6f, -2)), f);
                //  
                //  }
                //     if (transform.position == (new Vector3(-4, 0.6f, -2)))
                //    {

                //  tv.Rotate(new Vector3(90,90, 20),Time.deltaTime);
                // transform.rotation = Vector3.MoveTowards(transform.rotation (new Vector3(0, 90, 0 )));
                //  transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
                //  if (transform.Rotatoin == (new Vector3( 0,0,0))
                //   {

                // }
                // transform.position = Vector3.MoveTowards(transform.position, (new Vector3(0, 180, 0)), Time.deltaTime * f2);
                // if ( transform.rotation => (new Vector3(0, 90 ,0)))

                //  transform.position = Vector3.MoveTowards(transform.position, (new Vector3(4, 0.6f, -2)), f);

            }
       
        if (gesperkje.enabled == true)
        {
            
            anime.SetBool("loop", false);
            stLoop = false;
            anime.SetBool("hand", true);
        }
   // }
   // public void loopterug()
   // {
    //    if (go.transform.position == (new Vector3(-4, 0.6f, -2)))
    ///    {
     //       print("val");
     //   }
    }

  

            //   if (transform.position == (new Vector3(-4, 0.6f, -2)))
            //   {

            //   }


            //  }
            //  public void StopAnimatie ()
            //  {
            //    stLoop = false;
            //  }
        }
    }
       
