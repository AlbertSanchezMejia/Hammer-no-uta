using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigo : MonoBehaviour
{
    [SerializeField] GameObject enemigo;

    [SerializeField] Transform puntoInstanciar;
    [SerializeField] float tiempoSpawn;
    float tiempoMaximo;

    void Update()
    {
        tiempoMaximo += Time.deltaTime;
        if(tiempoMaximo >= tiempoSpawn)
        {
            Crear();
            tiempoMaximo = 0;
        }

    }

    void Crear()
    {
        Instantiate(enemigo, puntoInstanciar.position, transform.rotation);
    }

}
