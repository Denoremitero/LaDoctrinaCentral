using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] List<BasicObject> objetosObtenidos = new List<BasicObject>();
    [SerializeField] Animator animator;
    [SerializeField] LevelManager levelManager;
    [SerializeField] GameObject presionarE;

    public AudioSource audioSourceForPhrase;

    public void PickUp(BasicObject objeto)
    {
        objetosObtenidos.Add(objeto);
        Debug.Log("obtuve un objeto, tengo: " + objetosObtenidos.ToArray().Length);
        animator.SetTrigger("IsGrabbing");

        audioSourceForPhrase = this.GetComponent<AudioSource>();
        
        levelManager.UpdateCantidadObjetos(objetosObtenidos.ToArray().Length);
            
    }
    public void PlayPhrase(AudioClip clip)
    {
        if (clip == null)
        {
        }
        else
        {
            levelManager.gUIManager.currentKnownPhrases++;
            levelManager.gUIManager.UpdatePhraseButton(clip.name);
            audioSourceForPhrase.PlayOneShot(clip);
        }
    }
    public void EnablePresionarECanvas()
    {
        presionarE.SetActive(true);
    }
    public void DisablePresionarECanvas()
    {
        presionarE.SetActive(false);
    }

}
