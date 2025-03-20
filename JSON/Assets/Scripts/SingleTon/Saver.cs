using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Saver
{
    private const string _volumeSaveKey = "Volume";
    private const float _defaultVolume = 1f;

    public static void SaveVolume(float volume)
    {
        PlayerPrefs.SetFloat(_volumeSaveKey, volume);
        PlayerPrefs.Save();
    }

    public static float GetVolume() => PlayerPrefs.GetFloat(_volumeSaveKey, _defaultVolume);

    //too much
    /*public static bool TryGetVolume(out float volume)
    {
        volume = _defaultVolume;
        if (PlayerPrefs.HasKey(_volumeSaveKey))
        {
            volume = PlayerPrefs.GetFloat(_volumeSaveKey);
            return true;
        }
        return false;
    }*/
}
