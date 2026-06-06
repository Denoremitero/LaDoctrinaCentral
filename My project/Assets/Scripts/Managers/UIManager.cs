using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    //Main Menu
    [SerializeField] GameObject panelMainMenu;
    [SerializeField] GameObject panelOpciones;
    [SerializeField] AudioManager audioManager;

    //Nivel

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject); // Destruir duplicados
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Evitar que se destruya entre escenas
        }
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
        SceneManager.LoadScene("FirstPersonController");
    }
    public void CloseGame()
    {
        Application.Quit();
    }
    

    
}
