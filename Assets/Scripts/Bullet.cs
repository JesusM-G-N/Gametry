using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    
    // Movimiento del laser.
    void Update()
    {
        transform.Translate(0, 1 * bulletspeed * Time.deltaTime ,0 );
    }
}
