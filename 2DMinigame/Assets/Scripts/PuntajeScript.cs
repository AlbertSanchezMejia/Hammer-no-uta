using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuntajeScript : MonoBehaviour
{
    private int puntajeActual = 0;
    [SerializeField] Text textoPuntaje;

    public static int puntajeMaximo;
    [SerializeField] Text textoMaxPuntaje;

    void Start()
    {
        ActualizarPuntajeUI();
    }

    public void AumentarPuntaje()
    {
        puntajeActual++;
        if(puntajeActual > puntajeMaximo) puntajeMaximo = puntajeActual;
        ActualizarPuntajeUI();
    }

    void ActualizarPuntajeUI()
    {
        textoPuntaje.text = "" + puntajeActual;
        textoMaxPuntaje.text = "" + puntajeMaximo;
    }
}
