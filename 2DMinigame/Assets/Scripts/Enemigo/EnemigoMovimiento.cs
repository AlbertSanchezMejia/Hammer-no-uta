using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoMovimiento : MonoBehaviour
{
    Rigidbody2D rigidBody2d;
    [SerializeField] int velocidadMovimiento;

    void Start()
    {
        rigidBody2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody2d.velocity = -transform.right * velocidadMovimiento * Time.deltaTime * 10;
    }

}
