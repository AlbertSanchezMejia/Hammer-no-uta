using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtaqueScript : MonoBehaviour
{
    SacudirPantalla sacudir;
    PuntajeScript agregarPuntaje;

    [SerializeField] AudioSource sonido;

    void Start()
    {
        sacudir = FindObjectOfType<SacudirPantalla>();
        agregarPuntaje = FindObjectOfType<PuntajeScript>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo"))
        {
            sacudir.EmpezarSacudirPantalla();
            sonido.Play();
            agregarPuntaje.AumentarPuntaje();
        }
    }

}
