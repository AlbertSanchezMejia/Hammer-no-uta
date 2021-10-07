using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    void Update()
    {
        if (Time.timeScale == 1)
        {
            ChangeScale();
        }
    }
    void ChangeScale()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        int posX = worldPosition.x > 0 ? 1 : -1;
        transform.localScale = new Vector3(posX, 1, 1);
    }
}
