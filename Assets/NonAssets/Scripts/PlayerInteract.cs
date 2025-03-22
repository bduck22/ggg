using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    PlayerManager PlayerManager;
    void Start()
    {
        PlayerManager = GameManager.Instance.PlayerManager;
    }
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerManager.InteractObject = collision.transform.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (PlayerManager.InteractObject)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                PlayerManager.InteractObject.GetComponent<Interact>().interact();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerManager.InteractObject = null;
    }
}
