using UnityEngine;
using UnityEngine.Audio;

public class InitializeVolume : MonoBehaviour
{
    public float defaultVolume = 0.5f;
    public AudioMixerGroup masterMixer;
    public string mixerParameter;
    void Start()
    {
        UpdateMixer();
    }
    private void UpdateMixer()
    {
        float loadedValue = PlayerPrefs.GetFloat("MasterVolume", defaultVolume);
        float sliderValueLog = Mathf.Log10(loadedValue) * 20;
        masterMixer.audioMixer.SetFloat(mixerParameter, sliderValueLog);
    }
}
