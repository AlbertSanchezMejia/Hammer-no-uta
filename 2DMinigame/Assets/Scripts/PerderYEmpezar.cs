using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderYEmpezar : MonoBehaviour
{
    public static bool primeraPartida = false;

    [SerializeField] InstanciarEnemigo insE;
    [SerializeField] GameObject imagenPrimeraPartida;
    [SerializeField] GameObject imagenPerder;

    void Start()
    {
        Time.timeScale = 1;
        imagenPrimeraPartida.SetActive(!primeraPartida);
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
        Time.timeScale = 0;
        imagenPerder.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void ActivarInstaciarEnemigos()
    {
        insE.enabled = primeraPartida;
    }

}