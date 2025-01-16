using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float rotationspeed;
    [SerializeField] private float meteorspeed;
    void Update()
    {
       transform.Rotate(0, 0, 1 * rotationspeed * Time.deltaTime);

       transform.Translate(0, -1 * meteorspeed * Time.deltaTime, 0);
    }
   



    
  
    
}
    // Update is called once per frame

