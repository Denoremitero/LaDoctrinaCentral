using System.Collections;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public GameplayUIManager gUIManager;
    [SerializeField] GameObject gameOverCanvas;

    public bool questActive;
    public bool questComplete;

    int cantidadObjetosTotales;
    int cantidadObjetosActuales;
    private void Start()
    {
        gameOverCanvas.SetActive(false);
    }
    public void StartQuest()
    {
        questActive = true;
        cantidadObjetosTotales = GameObject.FindGameObjectsWithTag("ObjetoRecolectable").Length;

        Debug.Log("Inicio la quest, tienes que recolectar estos objetos: " + cantidadObjetosTotales);

        gUIManager.ShowQuestLog();
    }
    public void CheckQuestStatus()
    {
        if (questActive && (cantidadObjetosActuales == cantidadObjetosTotales) && !questComplete)
        {
            Cursor.lockState = CursorLockMode.None;
            questComplete = true;
            gUIManager.CompletedObjective();
            
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            int objetosFaltantes = cantidadObjetosTotales - cantidadObjetosActuales;
            Debug.Log("Faltan esta cantidad de objetos: " + objetosFaltantes);
        }
    }
    public void UpdateCantidadObjetos(int cantidadObjetosNueva)
    {
        cantidadObjetosActuales = cantidadObjetosNueva;
        
        
    }
    public IEnumerator GameOverSecuence()
    {
        GameOver();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene("MainMenu");
    }
    void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Debug.Log("El juego termino");
    }
}
