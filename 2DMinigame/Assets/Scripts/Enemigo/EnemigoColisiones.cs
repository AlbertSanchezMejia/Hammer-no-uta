using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoColisiones : MonoBehaviour
{
    [SerializeField] GameObject particulasDeMuerte;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Martillo"))
        {
            Instantiate(particulasDeMuerte, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
