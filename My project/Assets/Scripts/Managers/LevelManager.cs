using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public bool questActive;
    public bool questComplete;

    int cantidadObjetosTotales;
    int cantidadObjetosActuales;

    public void StartQuest()
    {
        questActive = true;
        cantidadObjetosTotales = GameObject.FindGameObjectsWithTag("ObjetoRecolectable").Length;

        Debug.Log("Inicio la quest, tienes que recolectar estos objetos: " + cantidadObjetosTotales);
    }
    public void CheckQuestStatus()
    {
        if (questActive && (cantidadObjetosActuales == cantidadObjetosTotales) && !questComplete)
        {
            questComplete = true;
            GameOver();
        }
        else
        {
            int objetosFaltantes = cantidadObjetosTotales - cantidadObjetosActuales;
            Debug.Log("Faltan esta cantidad de objetos: " + objetosFaltantes);
        }
    }
    public void UpdateCantidadObjetos(int cantidadObjetosNueva)
    {
        cantidadObjetosActuales = cantidadObjetosNueva;
        
        
    }
    void GameOver()
    {
        Debug.Log("El juego termino");
    }
}
