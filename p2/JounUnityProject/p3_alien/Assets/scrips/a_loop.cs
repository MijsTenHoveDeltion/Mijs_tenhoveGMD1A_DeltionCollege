using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_loop : MonoBehaviour
{
    public UIM_Talk uimtalk;
    public Animator anime;
    public float f;
    public bool stLoop;
    public bool retchs;
    public Canvas gesperkje;

    void Start()
    {
        anime.SetBool("loop", true);
        stLoop = true;
    }

    void Update()
    {
        if (transform.position.x > 4 &&  stLoop == true)
        {
            retchs = true;
            transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        }
        if(transform.position.x < -4 && stLoop == true)
        {
            retchs = false;
            transform.rotation = Quaternion.Euler(new Vector3(0, 90, 0));
        }
        //

        if(stLoop == true && retchs == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, (new Vector3(-4, 0.6f, -2)), f);
        }
        if (stLoop == true && retchs == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, (new Vector3(4, 0.6f, -2)), f);
        }
        if (gesperkje.enabled == true)
        {

            anime.SetBool("loop", false);
            stLoop = false;
            anime.SetBool("hand", true);
        }
    }
}

       
