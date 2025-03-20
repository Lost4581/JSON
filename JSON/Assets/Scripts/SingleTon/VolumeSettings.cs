using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] Slider _slider;
    [SerializeField] AudioMixer _mixer;

    private void Start()
    {
        float savedData = Saver.GetVolume();
        //TODO set saveData to mixer
        SlideVolume();
    }
    private void SlideVolume()
    {
        _slider.onValueChanged.AddListener(ValueChangeCheck);
    }
    private void ValueChangeCheck(float value)
    {
        _mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
        Saver.SaveVolume(value);
    }
}
