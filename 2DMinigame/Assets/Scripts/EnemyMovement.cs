using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D rigidBody;
    [SerializeField] int velocidadMovimiento;
    private int direccion = 1;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        AjustarDireccion();
    }

    void FixedUpdate()
    {
        rigidBody.velocity = -transform.right * velocidadMovimiento * direccion *Time.deltaTime * 10;
    }
    void AjustarDireccion()
    {
        direccion = transform.position.x > 0 ? 1 : -1;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }

}
