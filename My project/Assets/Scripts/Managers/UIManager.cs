using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelMainMenu;
    [SerializeField] GameObject panelOpciones;
    [SerializeField] Slider sliderVolumen;

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void EnterOptions()
    {
        panelOpciones.SetActive(true);
    }
    public void ExitOptions() 
    {
        panelOpciones.SetActive(false);
    }
    public void StartGame() 
    {
        SceneManager.LoadScene("Level1");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
}
