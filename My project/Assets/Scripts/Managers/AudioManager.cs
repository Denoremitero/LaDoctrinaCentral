using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider sliderVolumen;
    private float volumenMaestro;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    public void SetVolume()
    {
        volumenMaestro = Mathf.Log10(sliderVolumen.value) * 20;

        audioMixer.SetFloat("VolumenMaestro", volumenMaestro);
    }
}
