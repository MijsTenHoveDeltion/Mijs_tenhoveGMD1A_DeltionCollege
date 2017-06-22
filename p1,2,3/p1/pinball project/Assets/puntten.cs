using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class puntten : MonoBehaviour {

    // voor de text in de button
    public Text text;
 
     
    
    public void OnCollisionEnter(Collision collision)
    {
        // andere c# document code zorg voor dat er een punt bij komt
    Punten2.tellen = Punten2.tellen + 1;
    text.text = "points: " + Punten2.tellen.ToString();
              
            }
}
