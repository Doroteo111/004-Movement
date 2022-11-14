using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public float speed = 20f;
    public float turnSpeed = 10f;
    public float horizontalInput;
    void Update()
    {

        //detectar el input hoeizontal
        horizontalInput = Input.GetAxis("Horizontal");

        //Movimiento pa'lante
        //transform.Translate(0, 0, 1); 
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);

        //Movimiento lateral manual
        transform.Translate(Vector3.right * turnSpeed * Time.deltaTime * horizontalInput);

    }
}
