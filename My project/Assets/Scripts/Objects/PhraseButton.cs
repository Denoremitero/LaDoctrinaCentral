using TMPro;
using UnityEngine;

public class PhraseButton : MonoBehaviour
{
    public int phraseIndex;
    public string phraseText;

    [SerializeField] TextMeshProUGUI m_TextMeshPro;

    public void ChangePhraseText()
    {
        m_TextMeshPro.text = phraseText;
    }
}
