using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartilloAtaqueScript : MonoBehaviour
{
    SacudirPantalla sacudir;
    PuntajeScript agregarPuntaje;

    [SerializeField] AudioSource sfxGolpe;

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
            sfxGolpe.Play();
            agregarPuntaje.AumentarPuntaje();
        }
    }

}
