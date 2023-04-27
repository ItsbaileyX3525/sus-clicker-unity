using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VolumeSetattr : MonoBehaviour
{

    public TMP_Text volumeText;
    [SerializeField] private Slider SliderVolume = null;

    void Start()
    {
        loadVolume();
    }
    public void ChangeVolume(float volume)
    {
        volumeText.text = SliderVolume.value.ToString("0.0");
        AudioListener.volume = SliderVolume.value;
        float VolumeValue = SliderVolume.value;
        PlayerPrefs.SetFloat("VolumeValue", VolumeValue);
    }
    void loadVolume()
    {
        float volumeValue = PlayerPrefs.GetFloat("VolumeValue");
        SliderVolume.value = volumeValue;
        AudioListener.volume = volumeValue;
    }
}
