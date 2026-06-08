using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class PhrasesManager : MonoBehaviour
{
    [SerializeField] List<AudioClip> frasesClip = new List<AudioClip>();
    [SerializeField] List<GameObject> soundTriggers = new List<GameObject>();

    private void Start()
    {
        frasesClip.Shuffle();

        soundTriggers = GameObject.FindGameObjectsWithTag("SoundEvent").ToList();

        soundTriggers.Shuffle();
        FillSoundTriggers();

    }
    public void FillSoundTriggers()
    {
        for (int i = 0; i < soundTriggers.Count; i++)
        {
            soundTriggers[i].GetComponent<SoundEvent>().clip = frasesClip[i];
        }

    }
}
public static class ListExtentions
{
    public static void Shuffle<T>(this List<T> lista)
    {
        for (int i = lista.Count - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);

            T temp = lista[i];
            lista[i] = lista[randomIndex];
            lista[randomIndex] = temp;
        }
    }
}
