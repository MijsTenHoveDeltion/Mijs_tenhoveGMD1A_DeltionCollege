using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas startmenu;
    public Button startBut;
    public bool start;
   




    void Start()
    {
        startmenu = startmenu.GetComponent<Canvas>();
        startBut = startBut.GetComponent<Button>();
        startmenu.enabled = false;
    }


  public void startpress()
    {
        startmenu.enabled = true;

    }
   
    public void startlevel()
    {
        Application.LoadLevel(1);
    }
}
