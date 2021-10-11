using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarEnemigo : MonoBehaviour
{
    [SerializeField] float intervalo = 1f;
    float contador;

    [SerializeField] GameObject enemigoPrefab;
    [SerializeField] Transform[] posicion;

    void Update()
    {
        contador += Time.deltaTime;
        if(contador >= intervalo) InstanciarUnEnemigo();
    }

    void InstanciarUnEnemigo()
    {
        int numero = Random.Range(0, posicion.Length);
        Instantiate(enemigoPrefab, posicion[numero].position, posicion[numero].rotation);
        contador = 0;
    }

}