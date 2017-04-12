using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class UIM_Talk : MonoBehaviour
{ 
   public TManager tM;
    public Canvas canvasText;
    public GameObject praat;
    public a_loop ani;
    public Text jaa;
    public Text neee;
    public Text antwoord;
    public int ja1;
    public int nee2;
    

    public void Start()
    {

        canvasText.enabled = false;
    }
    public void Canvasklije(GameObject alien)
    {
        if (alien.gameObject.tag == ("Alien"))
        {
            canvasText.enabled = true;


         //   ani.StopAnimatie.(stloop = true);
        }
    }

    public void AntwoordJa( int i)
    {
      tM.OproepJa(i);
      tM.Oproepvraag(i);
        print("one");
    }

    public void ChangeButton(string buttonOne, string buttonTwo )
    {
        print("too");
        jaa.text = buttonOne;
        neee.text = buttonTwo;
    }
    public void aaa (string antwor)
    {
        antwoord.text = antwor;
        print("tree");
    }


        // int/punten
        //knoplingke/ je antwoord Ja/Nee
        // aan de TM de TM stuurt naar de EIText_
}


