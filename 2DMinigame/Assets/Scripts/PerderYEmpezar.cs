using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PerderYEmpezar : MonoBehaviour
{
    public static bool primeraPartida = false;

    [SerializeField] GameObject imagenPrimeraPartida;
    [SerializeField] GameObject imagenPerder;

    void Start()
    {
        Time.timeScale = primeraPartida ? 1 : 0;
        imagenPrimeraPartida.SetActive(!primeraPartida);
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