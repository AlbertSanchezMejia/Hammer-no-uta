using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarEnemigo : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    [SerializeField] float intervaloParaInstanciar;
    float tiempoParaInstanciar;

    void Update()
    {
        tiempoParaInstanciar += Time.deltaTime;

        if(tiempoParaInstanciar >= intervaloParaInstanciar) InstanciarUnEnemigo();

    }

    void InstanciarUnEnemigo()
    {
        Instantiate(enemigo, transform.position, transform.rotation);
        tiempoParaInstanciar = 0;
    }

}