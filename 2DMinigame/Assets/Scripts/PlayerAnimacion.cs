using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimacion : MonoBehaviour
{
    Animator animador;

    void Start()
    {
        animador = GetComponent<Animator>();   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & animador.GetCurrentAnimatorStateInfo(0).IsName("Iddle"))
        {
            animador.Play("AnimacionAtaque");
        }
    }

}
