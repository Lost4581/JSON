using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMusic : MonoBehaviour
{
    private static BGMusic _instance;
    public static BGMusic Instance => _instance;

    private void Awake()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [SerializeField] private AudioSource _audioSource;

    public void SetVolume(float value)
    {
        _audioSource.volume = value;
        Saver.SaveVolume(value);
    }
}
