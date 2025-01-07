using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spaceship_Control : MonoBehaviour
{
    
    [Header("Movement")]
    [SerializeField] private float movementSpeed;
    [SerializeField] private Transform Spaceship_transform;
    private Vector2 moveInput;

    // Update is called once per frame
    private void Update()
    { 

        transform.Translate (moveInput * Time.deltaTime * movementSpeed, Space.World);

        if (moveInput != Vector2.zero)
        {
            Spaceship_transform.up = moveInput;
        }


    }

    private void OnMove(InputValue value)
    {
         moveInput = value.Get<Vector2>();
    }
}
