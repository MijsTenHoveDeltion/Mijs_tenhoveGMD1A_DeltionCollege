using UnityEngine;
using System.Collections;

public class Movecode : MonoBehaviour
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

    // Update is called once per frame
    void Update()
    {

        //lijntje voor schietten
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);
        
        // rotatie

        float roLeftRight = Input.GetAxis("Mouse Y") * muis;
        transform.Rotate(0, roLeftRight, 0);

        verticalrotation -= Input.GetAxis("Mouse Y") * muis;
        verticalrotation = Mathf.Clamp(verticalrotation, -upDownRange, upDownRange);
        Camera.main.transform.localRotation = Quaternion.Euler(verticalrotation, 0, 0);
       // float roUpDown = Input.GetAxis("Mouse X") * muis;
       // Camera.main.transform.Rotate(roUpDown, 0, 0);


        //beweging
        float voorsnel = Input.GetAxis("Vertical") * snelheid;

        float sideSpeed = Input.GetAxis("Horizontal") * snelheid;

        Vector3 speed = new Vector3(sideSpeed, 500, voorsnel);

        speed = transform.rotation * speed;


        CharacterController cc = GetComponent<CharacterController>();
        cc.SimpleMove(speed);

    }
}