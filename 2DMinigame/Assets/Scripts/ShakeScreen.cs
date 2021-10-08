using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeScreen : MonoBehaviour
{
    [SerializeField] Transform camara;
    [SerializeField] float tiempoSacudir;

    float shakeDuration = 0f;
    float shakeMagnitude = 0.25f;
    float dampingSpeed = 1.0f;

    Vector3 initialPosition;

    void OnEnable()
    {
        initialPosition = camara.localPosition;
    }

    void Update()
    {
        if (shakeDuration > 0 && Time.timeScale != 0)
        {
            camara.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            camara.localPosition = initialPosition;
        }
    }

    public void TriggerShake()
    {
        shakeDuration = tiempoSacudir;
    }

}
