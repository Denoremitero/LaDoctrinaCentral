using TMPro;
using UnityEngine;

public class PhraseButton : MonoBehaviour
{
    public int phraseIndex  = 0;
    public string phraseText;

    [SerializeField] TextMeshProUGUI m_TextMeshPro;
    [SerializeField] GameplayUIManager m_GameplayUIManager;

    private void Start()
    {
        m_GameplayUIManager = FindFirstObjectByType<GameplayUIManager>();
    }
    public void ChangePhraseText()
    {
        if (m_TextMeshPro == null)
        {
            return;
        }
        else
        {
            m_TextMeshPro.text = phraseText;

        }
    }
    public void OnClickButtonPhrase()
    {
        m_GameplayUIManager.ButtonPhraseCompleter(phraseIndex);
    }
}
