using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColisiones : MonoBehaviour
{
    [SerializeField] GameObject loseImage;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Enemigo"))
        {
            loseImage.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
