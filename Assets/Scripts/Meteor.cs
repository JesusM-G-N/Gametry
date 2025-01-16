using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    
    [SerializeField] private float rotationspeed;
    [SerializeField] private float meteorspeed;

    // Movimiento y rotación de los meteoritos
    void Update()
    {
       transform.Rotate(0, 0, 1 * rotationspeed * Time.deltaTime);

       transform.Translate(0, -1 * meteorspeed * Time.deltaTime, 0, Space.World);
    }
    
}
   

