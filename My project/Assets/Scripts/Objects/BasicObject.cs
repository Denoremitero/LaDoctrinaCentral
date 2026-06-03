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
            PickUp();
        }
    }

    private void PickUp()
    {
        Debug.Log("Objeto recogido: " + gameObject.name);

        Destroy(gameObject);
    }
}