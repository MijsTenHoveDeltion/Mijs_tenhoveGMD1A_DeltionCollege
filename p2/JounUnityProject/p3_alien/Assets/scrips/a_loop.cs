using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a_loop : MonoBehaviour
{
    public Animator anime;
    public GameObject go;
    public float f;
    public float f2;
    public bool stLoop;
    public Transform tv;

    void Start ()
    {  
        anime.SetBool("loop", true);
        stLoop = true;
        tv = go.transform;
    }
	
	void Update ()
    {
        if (stLoop == true )
        {
            transform.position = Vector3.MoveTowards(transform.position, (new Vector3(-4, 0.6f, -2)),f);	
        }
        if (transform.position == (new Vector3(-4, 0.6f, -2)))
        {
          tv.Rotate(new Vector3(0,90, 0));
          ///  tv.rotation = Vector3.MoveTowards(transform.position, (new Vector3(0, 0, 0)));
        }
       
	}
    public void StopAnimatie ()
    {
        stLoop = false;
    }
}
