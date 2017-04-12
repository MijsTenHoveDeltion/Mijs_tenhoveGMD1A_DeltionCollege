using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartKlik : MonoBehaviour
{
    public Canvas canvas;
    public Text text;
    public GameObject man;

	void Start ()
    {
        canvas.enabled = false;
	}
	
    public void CanvasPopUp( GameObject mannen)
    {
        if (mannen.gameObject.tag == ("mann"))
        {
            canvas.enabled = true;
        }
    }
	
}
