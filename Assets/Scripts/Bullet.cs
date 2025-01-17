using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float bulletspeed;
    private float timer = 0f;
    public float lifetime = 5f;
    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    [SerializeField] private AudioClip clip;
    private CapsuleCollider2D capsuleCollider;
    private void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Translate(0, 1 * bulletspeed * Time.deltaTime, 0);

        timer += Time.deltaTime;

       
        if (timer >= lifetime)
        {
            Destroy(gameObject);
        }

        
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.PlayOneShot(clip);

        spriteRenderer.enabled = false;

        capsuleCollider.enabled = false;
    }
}
    