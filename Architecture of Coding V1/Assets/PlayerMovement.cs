using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform playerTransform;
    
    public float speed = 12f;
    public float mouseSens = 100f;

    private float _xRotation;
   

    private void Update()
    { 
        Walk();  
        //Rotate();
    }

    private void Walk()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        var move = (transform.right * x) + (transform.forward * z);

        controller.Move(move * (speed * Time.deltaTime));
    }

    private void Rotate()
    {
        var mouseX = Input.GetAxis("Mouse X") * mouseSens * Time.deltaTime;
        var mouseY = Input.GetAxis("Mouse Y") * mouseSens * Time.deltaTime;

        _xRotation -= mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(_xRotation,0f,0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
