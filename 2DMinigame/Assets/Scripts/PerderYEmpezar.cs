using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderYEmpezar : MonoBehaviour
{
    public static bool primeraPartida = false;
    public static bool hasPerdido = false;

    [SerializeField] InstanciarEnemigo instanciarEnemigos;
    [SerializeField] GameObject imagenPrimeraPartida;
    [SerializeField] GameObject imagenPerder;

    void Start()
    {
        hasPerdido = false;
        Time.timeScale = 1;
        imagenPrimeraPartida.SetActive(!primeraPartida);
        imagenPerder.SetActive(false);
        ActivarInstaciarEnemigos();
    }

    void Update()
    {
        if(!primeraPartida & Input.GetMouseButtonDown(0)) EmpezarPartida();
    }

    void EmpezarPartida()
    {
        imagenPrimeraPartida.SetActive(false);
        Time.timeScale = 1;
        primeraPartida = true;
        ActivarInstaciarEnemigos();
    }

    public void Perder()
    {
        hasPerdido = true;
        Time.timeScale = 0;
        imagenPerder.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ActivarInstaciarEnemigos()
    {
        instanciarEnemigos.enabled = primeraPartida;
    }

}