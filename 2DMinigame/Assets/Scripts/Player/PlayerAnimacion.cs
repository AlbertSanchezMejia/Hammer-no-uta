using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimacion : MonoBehaviour
{
    [SerializeField] Animator animador;
    [SerializeField] AudioSource sfxAtacar;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) & animador.GetCurrentAnimatorStateInfo(0).IsName("Iddle") && Time.timeScale == 1)
        {
            animador.Play("AnimacionAtaque");
            sfxAtacar.Play();
        }
    }

}
