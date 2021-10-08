using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtaqueScript : MonoBehaviour
{
    ShakeScreen sacudir;
    [SerializeField] AudioSource sonido;

    void Start()
    {
        sacudir = FindObjectOfType<ShakeScreen>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo"))
        {
            sacudir.TriggerShake();
            sonido.Play();
        }
    }

}
