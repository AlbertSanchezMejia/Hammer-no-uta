using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisiones : MonoBehaviour
{
    PerderYEmpezar perder;
    [SerializeField] GameObject particulasDeMuerte;
    [SerializeField] AudioSource sfxMuerte;

    void Start()
    {
        perder = FindObjectOfType<PerderYEmpezar>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo"))
        {
            Instantiate(particulasDeMuerte, transform.position, transform.rotation);
            sfxMuerte.Play();
            Time.timeScale = 0.25f;
            gameObject.SetActive(false);
            Invoke("Perder", 0.1f);
        }
    }
    void Perder()
    {
        Time.timeScale = 0;
        perder.Perder();
    }
}
