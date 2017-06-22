using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Dead : MonoBehaviour {

    // voor laten zien van text in de butten
    public Text text;

    public void OnCollisionEnter(Collision colision)
    {
        // zorgt ervoor dat er 1 af gaat 
        print("test");
        Dead2.lives = Dead2.lives + 0;
        text.text = "lives:  " + Dead2.lives.ToString();
      

    } 

  

}


