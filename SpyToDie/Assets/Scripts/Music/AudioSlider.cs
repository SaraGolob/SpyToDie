using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class AudioSlider : MonoBehaviour
{
    public Slider slider;
    public AudioMixerGroup masterMixer;
    public TMP_Text percentage;
    public string mixerParameter;
    public float defaultVolume = 0.5f;

    private float lastSliderValue;
    private bool initialized = false;

    private void OnEnable()
    {
        if (!initialized)
        {
            return;
        }
        Initialize(PlayerPrefs.GetFloat("MasterVolume", defaultVolume)); //saves preferences(options) on a computer
    }
    private void Start()
    {
        Initialize(PlayerPrefs.GetFloat("MasterVolume", defaultVolume));
        initialized = true;
    }
    private void Initialize(float initialVolume)
    {
        UpdateMixer(initialVolume);
        UpdateSlider(initialVolume);
    }
    public void SetVolume(float sliderValue)
    {
        lastSliderValue = sliderValue;
        UpdateMixer(sliderValue);
        percentage.text = Mathf.Round(slider.value * 100f).ToString();
    }
    public void SaveSliderValue()
    {
        PlayerPrefs.SetFloat("MasterVolume", lastSliderValue);
    }
    private void UpdateMixer(float newVolume)
    {
        float sliderValueLog = Mathf.Log10(newVolume)*20;
        masterMixer.audioMixer.SetFloat(mixerParameter, sliderValueLog);
    }
    private void UpdateSlider(float newVolume)
    {
        slider.value = newVolume;
        percentage.text = Mathf.Round(slider.value * 100f).ToString();
    }
}
