using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausarJuego : MonoBehaviour
{
    bool estaPausado;

    void Start()
    {
        estaPausado = true;
        ContinuaryPausar();
    }

    void Update()
    {
        if (PerderYEmpezar.hasPerdido == false) PausarYContinuar();
    }

    void PausarYContinuar()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            estaPausado = !estaPausado;
            ContinuaryPausar();
        }
    }

    void ContinuaryPausar()
    {
        Time.timeScale = estaPausado ? 1 : 0;
    }

}
