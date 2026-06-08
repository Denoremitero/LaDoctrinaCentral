using UnityEngine;

public class RitualController : MonoBehaviour
{
    [SerializeField] LevelManager levelManager;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (levelManager.questActive)
            {
                levelManager.CheckQuestStatus();
                levelManager.gUIManager.ShowQuestLog();
            }
            else
            {
                levelManager.StartQuest();
                
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        levelManager.gUIManager.HideQuestLog();
    }
}
