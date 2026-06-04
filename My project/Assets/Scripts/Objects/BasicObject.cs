using UnityEngine;

public class BasicObject : MonoBehaviour
{
    private GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            player.GetComponent<PlayerInfo>().PickUp(this);
            Destroy(this.gameObject);
        }
    }
}