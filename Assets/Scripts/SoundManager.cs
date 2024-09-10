using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioSource audioSource;
    public AudioClip shootClip;
    public AudioClip explosionClip;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("SoundManager instanciado.");
        }
        else
        {
            Destroy(gameObject);
            Debug.Log("Instancia duplicada de SoundManager destruida.");
        }
    }

    public void PlaySound(string soundName)
    {
        switch (soundName)
        {
            case "shoot":
                audioSource.PlayOneShot(shootClip);
                Debug.Log("Sonido de disparo.");
                break;
            case "explosion":
                audioSource.PlayOneShot(explosionClip);
                Debug.Log("Sonido de explosión.");
                break;
            default:
                Debug.LogWarning("Sonido no encontrado: " + soundName);
                break;
        }
    }

    public void StopSound()
    {
        audioSource.Stop();
        Debug.Log("Sonido detenido.");
    }
}