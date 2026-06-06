using UnityEngine;

public class BasicObject : MonoBehaviour
{
    private GameObject player;
    [SerializeField] AudioSource grabSound;
    PlayerInfo playerInfo;
    bool isOutlineActive;
    bool isPlayerInside;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerInfo = player.GetComponent<PlayerInfo>();
        //grabSound = this.GetComponent<AudioSource>();
        isOutlineActive = false;
        isPlayerInside = false;
        gameObject.GetComponent<Outline>().enabled = isOutlineActive;
    }
    private void Update()
    {
        if (isPlayerInside && Input.GetKeyDown(KeyCode.E))
        {
            player.GetComponent<PlayerInfo>().PickUp(this);
            AudioSource.PlayClipAtPoint(grabSound.clip, transform.position, grabSound.volume);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            isPlayerInside = true;

            playerInfo.EnablePresionarECanvas();
            isOutlineActive = true;
            gameObject.GetComponent<Outline>().enabled = isOutlineActive; 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isOutlineActive = false;
        isPlayerInside = false;

        playerInfo.DisablePresionarECanvas();
        gameObject.GetComponent<Outline>().enabled = isOutlineActive;

    }
    private void OnDestroy()
    {
        playerInfo.DisablePresionarECanvas();
    }
}