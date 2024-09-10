using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            score++;
            Debug.Log("Puntaje incrementado: " + score);

            if (score >= 5)
            {
                CompleteLevel();
            }
        }
    }

    void CompleteLevel()
    {
        Debug.Log("¡Nivel completado! Reproduciendo sonido de explosión.");
        SoundManager.instance.PlaySound("explosion");
    }
}