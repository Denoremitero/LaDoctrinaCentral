using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameplayUIManager : MonoBehaviour
{
    [SerializeField] GameObject questLog;
    [SerializeField] List<string> objetivos = new List<string>();

    [SerializeField] TextMeshProUGUI objetivoTextDisplay;

    [SerializeField] GameObject buttonPhrase1;
    [SerializeField] GameObject buttonPhrase2;  
    [SerializeField] GameObject buttonPhrase3;

    public int currentObjetivo = 0;
    public int currentKnownPhrases = 0;
    int phrasesQuantityInput = 0;


    public void ShowQuestLog()
    {
        questLog.SetActive(true);
        ChangeObjective();
    }
    public void HideQuestLog()
    {
        questLog.SetActive(false);
    }
    public void CompletedObjective()
    {
        currentObjetivo++;
        ChangeObjective();
    }
    public void ChangeObjective()
    {
        objetivoTextDisplay.text = objetivos[currentObjetivo];
    }
    public void ButtonPhraseCompleter()
    {
        if (phrasesQuantityInput == 3)
        {
            OrderCheckForPhrases();
        }
        else 
        {
            phrasesQuantityInput++;
        }
    }
    public void OrderCheckForPhrases()
    {

    }
    public void UpdatePhraseButton(string clipName)
    {
        if (currentKnownPhrases == 1)
        {
            FillButtonPhrase(clipName);
        }
        else if (currentKnownPhrases == 2) 
        {
            FillButtonPhrase(clipName);
        }
        else
        {
            FillButtonPhrase(clipName);
        }
    }
    private void FillButtonPhrase(string clipName)
    {
        if (clipName == "Frase1")
        {
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseText = "Lo perdido no fue ocultado.";
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseIndex = 1;
        }
        else if (clipName == "Frase2")
        {
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseText = "Fue escuchado de manera incorrecta.";
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseIndex = 2;
        }
        else
        {
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseText = "Por eso el segundo silencio permanece.";
            buttonPhrase1.GetComponentInChildren<PhraseButton>().phraseIndex = 3;
        }
    }
    
}
