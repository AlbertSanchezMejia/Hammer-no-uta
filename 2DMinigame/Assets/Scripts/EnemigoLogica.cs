using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoLogica : MonoBehaviour
{
    Rigidbody2D rigidBody2d;
    [SerializeField] int velocidadMovimiento;
    [SerializeField] GameObject particulasDeMuerte;

    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody2d.velocity = -transform.right * velocidadMovimiento * Time.deltaTime * 10;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Instantiate(particulasDeMuerte, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }

}
