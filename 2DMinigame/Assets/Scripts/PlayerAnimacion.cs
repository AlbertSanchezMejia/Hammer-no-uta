using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimacion : MonoBehaviour
{
    Animator animador;
    [SerializeField] AudioSource sonido;

    void Start()
    {
        animador = GetComponent<Animator>();   
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & animador.GetCurrentAnimatorStateInfo(0).IsName("Iddle") && Time.timeScale == 1)
        {
            animador.Play("AnimacionAtaque");
            sonido.Play();
        }
    }

}
