using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spaceship_Control : MonoBehaviour
{


    [Header("Movement")]
    [SerializeField] private float movementSpeed;
    private Vector2 moveInput;

    [Header("Shoot")]
    [SerializeField] private GameObject Bulletprefab;

    [Header("Meteor")]
    [SerializeField] private GameObject Meteorprefab;
    private float xMax, yMax, xMin, yMin;

    public int meteorCount = 0;  // Contador de meteoritos 
    [SerializeField] private int maxMeteor = 3;  // Número máximo de meteoritos
    private void Start()
    {
        xMax = 10; yMax = 8; xMin = -10; yMin = 7;
        InvokeRepeating("SpawnMeteor", 2f, 2f);  // Llamamos a SpawnMeteor

    }
    private void Update()
    {
        // Movimiento de la Nave
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10, 10), Mathf.Clamp(transform.position.y, -4.5f, 4.5f));
        transform.Translate(moveInput * Time.deltaTime * movementSpeed, Space.World);

        if (moveInput != Vector2.zero)
        {
            transform.up = moveInput;
        }
    }

    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void OnShoot()
    {
        Instantiate(Bulletprefab, transform.position, transform.rotation);
    }

    // Método para crear meteoritos
    private void SpawnMeteor()
    {
        if (meteorCount < maxMeteor) 
        {
            float randomX = Random.Range(xMax, xMin);
            float randomY = Random.Range(yMax, yMin);
            
            Instantiate(Meteorprefab, new Vector2(randomX, randomY), Quaternion.identity);
            meteorCount++;  // Aumenta el contador de meteoritos
        }
    }

    // Método para generar nuevos meteoritos
    public void DecreaseMeteorCount()
    {
        if (meteorCount > 0)
        {
            meteorCount--;  //Reduce el contador de meteoritos
            SpawnMeteor();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }   
}
