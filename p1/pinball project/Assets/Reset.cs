using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour {
    // herhaalt 
public void opnew ()
    {
        //erste scherm weer laaten zien
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
