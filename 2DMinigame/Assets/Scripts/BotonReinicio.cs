using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonReinicio : MonoBehaviour
{
    [SerializeField] GameObject imagenInicio;
    public static bool primeraPartida = false;

    void Start()
    {
        Time.timeScale = primeraPartida ? 1 : 0;
        imagenInicio.SetActive(!primeraPartida);

    }
    void Update()
    {
        if(!primeraPartida)
        {
            if (Input.GetMouseButtonDown(0))
            {
                imagenInicio.SetActive(false);
                Time.timeScale = 1;
                primeraPartida = true;
            }
        }

    }
    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
