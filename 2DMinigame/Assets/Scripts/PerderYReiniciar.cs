using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderYReiniciar : MonoBehaviour
{
    public static bool primeraPartida = false;

    [SerializeField] GameObject imagenInicioPartida;
    [SerializeField] GameObject imagenPerder;

    void Start()
    {
        Time.timeScale = primeraPartida ? 1 : 0;
        imagenInicioPartida.SetActive(!primeraPartida);
    }

    void Update()
    {
        if(!primeraPartida & Input.GetMouseButtonDown(0)) EmpezarPartida();
    }

    void EmpezarPartida()
    {
        imagenInicioPartida.SetActive(false);
        Time.timeScale = 1;
        primeraPartida = true;
    }

    public void Perder()
    {
        Time.timeScale = 0;
        imagenPerder.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}