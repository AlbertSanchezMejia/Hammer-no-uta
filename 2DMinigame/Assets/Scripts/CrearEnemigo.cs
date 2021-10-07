using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigo : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    [SerializeField] float tiempoSpawn;
    float tiempoMaximo;
    [SerializeField] Transform[] puntosInstanciar;


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
        int valor = Random.Range(0, 2);
        Instantiate(enemigo, puntosInstanciar[valor].position, transform.rotation);
    }

}
