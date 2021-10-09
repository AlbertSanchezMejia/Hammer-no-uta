using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisiones : MonoBehaviour
{
    PerderYReiniciar perderYreiniciar;

    void Start()
    {
        perderYreiniciar = FindObjectOfType<PerderYReiniciar>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo"))
        {
            perderYreiniciar.Perder();
        }
    }

}
