using UnityEngine;

public class SoundEvent : MonoBehaviour
{
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        if (clip == null)
        {
            return;
        }
        else
        {
            other.GetComponent<PlayerInfo>().PlayPhrase(clip);
        }
        Destroy(gameObject);
    }
}
