using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private Spaceship_Control spaceshipControl;
    [SerializeField] private float rotationspeed;
    [SerializeField] private float meteorspeed;
    private float timer = 0f;
    public float lifetime = 5f;
   

  

    void Start()
    {
        // Obtener el script Spaceship_Control de la escena
        spaceshipControl = FindObjectOfType<Spaceship_Control>();
        
    }
    void Update()
    {
       transform.Rotate(0, 0, 1 * rotationspeed * Time.deltaTime);

       transform.Translate(0, -1 * meteorspeed * Time.deltaTime, 0, Space.World);

        timer += Time.deltaTime;


        if (timer >= lifetime)
        {
            Destroy(gameObject);
            spaceshipControl.DecreaseMeteorCount();
        }
       
    }

   

    private void OnCollisionEnter2D(Collision2D collision)
    {
        

        Destroy(gameObject);

        spaceshipControl.DecreaseMeteorCount();
       
    }

}
   

