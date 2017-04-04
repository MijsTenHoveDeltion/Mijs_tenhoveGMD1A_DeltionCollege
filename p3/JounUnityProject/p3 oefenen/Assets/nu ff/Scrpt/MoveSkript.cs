using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSkript : MonoBehaviour
{


    public float snelheid = 5.0f;
    public float muis = 5.0f;

    float verticalrotation = 0;
    public float upDownRange = 60.0f;

    float verticalVelocity = 0;

    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    void Update()
    {
        float voorsnel = Input.GetAxis("Vertical") * snelheid;

        float sideSpeed = Input.GetAxis("Horizontal") * snelheid;

        Vector3 speed = new Vector3(sideSpeed, 500, voorsnel);

        speed = transform.rotation * speed;


        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);
    }
}


