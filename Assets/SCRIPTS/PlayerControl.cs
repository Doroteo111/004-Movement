using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 40f;
    public float horizontalInput, verticalInput;  //CÓDIGO LIMPIO 

     

    void Update()
    {

        //detectar el input hoeizontal
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        //Movimiento pa'lante
        //transform.Translate(0, 0, 1); 
        transform.Translate(Vector3.forward * 20 * Time.deltaTime * verticalInput);

        //Movimiento lateral manual
        /*transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);*/
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
