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

    [SerializeField] GameObject panelPhrases;

    private int[] correctOrder = { 1, 2, 3 };

    public int currentObjetivo = 0;
    public int currentKnownPhrases = 0;
    int currentCorrectAnswers = 0;
    List<int> phrasesQuantityInput = new List<int>();


    public void ShowQuestLog()
    {
        questLog.SetActive(true);
        ChangeObjective();

        if (currentObjetivo == 1)
        {
            panelPhrases.SetActive(true);
        }
        else
        {
            panelPhrases.SetActive(false);
        }

    }
    public void HideQuestLog()
    {
        questLog.SetActive(false);
        panelPhrases.SetActive(false);
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
    public void ButtonPhraseCompleter(int phraseIndex)
    {
        if (phrasesQuantityInput.Count == 3)
        {
            OrderCheckForPhrases();
        }
        else 
        {
            phrasesQuantityInput.Add(phraseIndex);
        }
    }
    public bool OrderCheckForPhrases()
    {
        
        int i = 0;
        foreach (int a in correctOrder)
        {
        if (a == phrasesQuantityInput[i])
        {
            currentCorrectAnswers++;
        }
        else
        {
            phrasesQuantityInput.Clear();
            currentCorrectAnswers = 0;
            return false;
        }
        }
        if (currentCorrectAnswers == 2)
            return true;
        else
            return false;
        

    }
    public void UpdatePhraseButton(string clipName)
    {
        if (currentKnownPhrases == 1)
        {
            FillButtonPhrase(clipName, buttonPhrase1);
        }
        else if (currentKnownPhrases == 2) 
        {
            FillButtonPhrase(clipName, buttonPhrase2);
        }
        else
        {
            FillButtonPhrase(clipName, buttonPhrase3);
        }
    }
    private void FillButtonPhrase(string clipName, GameObject buttonPhrase)
    {
        if (clipName == "Frase1")
        {
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseText = "Lo perdido no fue ocultado.";
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseIndex = 1;
            buttonPhrase.GetComponentInChildren<PhraseButton>().ChangePhraseText();
        }
        else if (clipName == "Frase2")
        {
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseText = "Fue escuchado de manera incorrecta.";
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseIndex = 2;
            buttonPhrase.GetComponentInChildren<PhraseButton>().ChangePhraseText();
        }
        else
        {
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseText = "Por eso el segundo silencio permanece.";
            buttonPhrase.GetComponentInChildren<PhraseButton>().phraseIndex = 3;
            buttonPhrase.GetComponentInChildren<PhraseButton>().ChangePhraseText();
        }
    }
    
}
