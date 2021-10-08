using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] int velocidadMovimiento;
    [SerializeField] GameObject deathParticles;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody.velocity = -transform.right * velocidadMovimiento *Time.deltaTime * 10;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(deathParticles, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
